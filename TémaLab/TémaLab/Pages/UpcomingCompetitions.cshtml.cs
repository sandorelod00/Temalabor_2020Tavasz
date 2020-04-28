using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TémaLab.Data.DTOs;
using TémaLab.Data.Services;

namespace TémaLab
{
    public class UpcomingCompetitionsModel : PageModel
    {
        public IEnumerable<CompetitionDto> Competions;
        public void OnGet([FromServices]CompetitionService competitionService)
        {
            Competions = competitionService.GetCompetitions();
        }
    }
}