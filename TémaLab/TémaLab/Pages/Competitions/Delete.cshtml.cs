using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TémaLab.Data;
using TémaLab.Data.DTOs;
using TémaLab.Data.Entities;
using TémaLab.Data.Services;

namespace TémaLab
{
    public class DeleteModel : PageModel
    {
        private readonly CompetitionService _competitionService;

        public DeleteModel(CompetitionService comptetionService)
        {
            _competitionService = comptetionService;
        }

    public Competition CompetitionDto { get; set; }
    public User User { get; set; }
    public async Task<IActionResult> OnGetAsync(int? id, [FromServices]UserManager<User> userManager)
        {
            User = await userManager.GetUserAsync(HttpContext.User);
            if (User == null || !User.Admin)
            {
                return BadRequest();
            }
            if (id == null)
            {
                return NotFound();
            }

            CompetitionDto = _competitionService.GetCompetition(id);

            if (CompetitionDto != null)
            {
                _competitionService.Delete(CompetitionDto);
            }

            return RedirectToPage("./Index");

        }


    }
}
