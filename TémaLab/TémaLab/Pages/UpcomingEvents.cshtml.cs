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
    public class UpcomingEventsModel : PageModel
    {
        public IEnumerable<EventDto> Events { get; set; }
        public void OnGet([FromServices]EventService eventService)
        {
            Events = eventService.GetEvents();
        }
    }
}