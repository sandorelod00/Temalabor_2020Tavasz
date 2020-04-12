using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TémaLab.Data.Entities
{
    public class Participation
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int CompetitionId { get; set; }

        public Competition Competition { get; set; }

        public DateTime date { get; set; }
    }
}
