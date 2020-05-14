using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TémaLab.Data;
using TémaLab.Data.DTOs;
using TémaLab.Data.Services;

namespace TémaLab
{
    public class IndexModel : PageModel
    {
        private readonly CompetitionService _competitionService;

        public IndexModel(CompetitionService comptetionService)
        {
            _competitionService = comptetionService;
        }

        public IEnumerable<CompetitionDto> Competitons;
        public void OnGet()
        {
            Competitons = _competitionService.GetCompetitions();
        }
    }
}
