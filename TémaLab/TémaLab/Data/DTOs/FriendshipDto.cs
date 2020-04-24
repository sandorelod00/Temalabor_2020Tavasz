using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.Entities;

namespace TémaLab.Data.DTOs
{
    public class FriendshipDto
    {
        public int User1Id { get; set; }
        public virtual User User1 { get; set; }
        public int User2Id { get; set; }
        public virtual User User2 { get; set; }
    }
}
