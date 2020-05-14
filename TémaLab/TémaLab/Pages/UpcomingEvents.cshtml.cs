using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TémaLab.Data;
using TémaLab.Data.DTOs;
using TémaLab.Data.Entities;
using TémaLab.Data.Services;

namespace TémaLab
{
    public class UpcomingEventsModel : PageModel
    {
        private readonly EventService _eventService;

        public UpcomingEventsModel([FromServices]EventService eventService)
        {
            _eventService = eventService;
        }

        public IEnumerable<EventDto> Events { get; set; }

        public void OnGet()
        {
            Events = _eventService.GetEvents();
        }
    }
}