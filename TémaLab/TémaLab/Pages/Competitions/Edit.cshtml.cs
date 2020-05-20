using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TémaLab.Data;
using TémaLab.Data.DTOs;
using TémaLab.Data.Entities;
using TémaLab.Data.Services;

namespace TémaLab
{
    public class EditModel : PageModel
    {
        private readonly CompetitionService _competitionService;
        private readonly ParticipationService _participationService;
        private readonly UserService _userService;

        public EditModel(CompetitionService comptetionService, ParticipationService participationService, UserService userService)
        {
            _competitionService = comptetionService;
            _participationService = participationService;
            _userService = userService;
        }

        [BindProperty]
        public CompetitionDto CompetitionDto { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id, [FromServices]UserManager<User> userManager)
        {
            if (id == null)
            {
                return NotFound();
            }

            CompetitionDto = _competitionService.GetCompetitions().Single(c => c.Id == id);
            //Participations = _participationService.GetParticipationById(id).ToList();
            if (CompetitionDto == null)
            {
                return NotFound();
            }
            return Page();


        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _competitionService.updateCompetition(CompetitionDto);
            //_context.Attach(CompetitionDto).State = EntityState.Modified;

            try
            {
              //  await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
 
            }

            return RedirectToPage("./Index");
        }

    }
}
