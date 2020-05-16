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
    public class DetailsModel : PageModel
    {
        private readonly CompetitionService _competitionService;

        public DetailsModel(CompetitionService comptetionService)
        {
            _competitionService = comptetionService;
        }

        public CompetitionDto CompetitionDto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CompetitionDto = _competitionService.GetCompetitions().Single(c => c.Id == id);

            if (CompetitionDto == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
