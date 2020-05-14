using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TémaLab.Data.Services;
using TémaLab.Data.DTOs;

namespace TémaLab
{
    public class UpcomingCompetitionsModel : PageModel
    {

        private readonly CompetitionService _competitionService;

        public UpcomingCompetitionsModel([FromServices]CompetitionService comptetionService)
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