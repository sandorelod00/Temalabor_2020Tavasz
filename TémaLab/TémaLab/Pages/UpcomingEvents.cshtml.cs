using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TémaLab.Data;
using TémaLab.Data.Entities;

namespace TémaLab
{
    public class UpcomingEventsModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public UpcomingEventsModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Event> Events { get; set; }

        public void OnGet()
        {
            Events = _dbContext.Events.ToList();
        }
    }
}