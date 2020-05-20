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
    public class IndexModel : PageModel
    {
        private readonly CompetitionService _competitionService;
        private readonly UserService _userService;

        public User? User { get; private set; }
        public IEnumerable<string>? Roles { get; private set; }

        public IndexModel(CompetitionService comptetionService, [FromServices] UserService userService)
        {
            _competitionService = comptetionService;
            _userService = userService;
           
        }

        public IEnumerable<CompetitionDto> Competitons;
        public async Task OnGetAsync([FromServices]UserManager<User> userManager)
        {
            User = await userManager.GetUserAsync(HttpContext.User);
            Competitons = _competitionService.GetCompetitions();
        }
    }
}
