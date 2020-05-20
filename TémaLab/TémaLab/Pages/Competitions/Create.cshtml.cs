using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TémaLab.Data;
using TémaLab.Data.DTOs;
using TémaLab.Data.Entities;
using TémaLab.Data.Services;

namespace TémaLab
{
    public class CreateModel : PageModel
    {
        private readonly CompetitionService _competitionService;
      
        public CreateModel(CompetitionService comptetionService)
        {
            _competitionService = comptetionService;
        }

        public async Task<IActionResult> OnGetAsync([FromServices]UserManager<User> userManager)
        {
            User = await userManager.GetUserAsync(HttpContext.User);
            if(User == null || !User.Admin)
            {
                return BadRequest();
            }

            //ViewData["UserId"] = new SelectList(_competitionService.GetUsers, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public CompetitionDto CompetitionDto { get; set; }
        public User User { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync([FromServices]UserManager<User> userManager)
        {
            User = await userManager.GetUserAsync(HttpContext.User);

            Competition newCompetition = new Competition()
            {
                UserId = User.Id,
                Title = CompetitionDto.Title,
                Content = CompetitionDto.Content
            };


            _competitionService.AddCompetition(newCompetition);

            return RedirectToPage("./Index");
        }
    }
}
