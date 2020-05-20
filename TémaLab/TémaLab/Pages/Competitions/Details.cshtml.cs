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
    public class DetailsModel : PageModel
    {
        private readonly CompetitionService _competitionService;
        private readonly ParticipationService _participationService;
        private readonly UserService _userService;

        public DetailsModel(CompetitionService comptetionService, ParticipationService participationService, UserService userService)
        {
            _competitionService = comptetionService;
            _participationService = participationService;
            _userService = userService;
        }

        public CompetitionDto CompetitionDto { get; set; }
        public List<ParticipationDto> Participations { get; set; }
        public User? User { get; private set; }

        public async Task<IActionResult> OnGetAsync(int? id, [FromServices]UserManager<User> userManager)
        {
            User = await userManager.GetUserAsync(HttpContext.User);
            if (id == null)
            {
                return NotFound();
            }

            CompetitionDto = _competitionService.GetCompetitions().Single(c => c.Id == id);
            Participations = _participationService.GetParticipationById(id).ToList();
            if (CompetitionDto == null)
            {
                return NotFound();
            }
            return Page();
        }


        public async Task<ActionResult> OnPostRegister(int? id, [FromServices]UserManager<User> userManager)
        {
            User = await userManager.GetUserAsync(HttpContext.User);
            CompetitionDto = _competitionService.GetCompetitions().Single(c => c.Id == id);
            Participation par = new Participation()
            {
                CompetitionId = CompetitionDto.Id,
                UserId = User.Id
            };
            _participationService.addParticipation(par);

            return Redirect($"./Details?id=" + id);
        }

        public async Task<ActionResult> OnPostUnregister(int? id, [FromServices]UserManager<User> userManager)
        {
            User = await userManager.GetUserAsync(HttpContext.User);
            CompetitionDto = _competitionService.GetCompetitions().Single(c => c.Id == id);

            _participationService.removeParticipation(id, User.Id);

            return Redirect($"./Details?id=" + id);
        }


    }
}
