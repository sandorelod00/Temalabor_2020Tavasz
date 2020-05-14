using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TémaLab.Data;
using TémaLab.Data.DTOs;
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

        public IActionResult OnGet()
        {
        //ViewData["UserId"] = new SelectList(_competitionService.GetUsers, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public CompetitionDto CompetitionDto { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var a = CompetitionDto;
            //_competitionService.AddCompetition(CompetitionDto);

            return RedirectToPage("./Index");
        }
    }
}
