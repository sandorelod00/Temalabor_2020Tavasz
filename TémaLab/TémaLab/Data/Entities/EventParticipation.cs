﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TémaLab.Data.Entities
{
    public class EventParticipation
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int EventId { get; set; }

        public Event Event{ get; set; }

        public DateTime date { get; set; }
    }
}
