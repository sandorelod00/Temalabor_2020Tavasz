using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TémaLab.Data.DTOs;
using TémaLab.Data.Services;

namespace TémaLab.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IEnumerable<UserDto> Users { get; private set; }
        public IEnumerable<CompetitionDto> Competitions{ get; private set; }
        public string Message { get; private set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet([FromServices]UserService userService, [FromServices]CompetitionService competitionService)
        {
            //this.Users = userService.GetUsers();
            //var users = Users.ToList();
            //this.Competitions = competitionService.GetCompetitions();
            //var competitions = Competitions.ToList();
            //Message = users.ElementAt(0).UserName;


        }
    }
}
