using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

    public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CompetitionDto = _competitionService.GetCompetition(id);

            if (CompetitionDto == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
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
