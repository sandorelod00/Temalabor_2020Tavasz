using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TémaLab.Data;
using TémaLab.Data.DTOs;

namespace TémaLab
{
    public class EditModel : PageModel
    {
        private readonly TémaLab.Data.ApplicationDbContext _context;

        public EditModel(TémaLab.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CompetitionDto CompetitionDto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CompetitionDto = await _context.CompetitionDto
                .Include(c => c.User).FirstOrDefaultAsync(m => m.Id == id);

            if (CompetitionDto == null)
            {
                return NotFound();
            }
           ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
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

            _context.Attach(CompetitionDto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompetitionDtoExists(CompetitionDto.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CompetitionDtoExists(int id)
        {
            return _context.CompetitionDto.Any(e => e.Id == id);
        }
    }
}
