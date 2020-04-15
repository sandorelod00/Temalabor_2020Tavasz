using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TémaLab.Data.Entities
{
    public class Friendship
    {
        public int Id { get; set; }
        
        [Required]
        public int User1Id { get; set; }

        //[ForeignKey("User1Id")]
        //[InverseProperty("Friendships")]
        [Required]
        public User User1 { get; set; }
        
        [Required]
        public int User2Id { get; set; }

        //[ForeignKey("User2Id")]
        [Required]
        public User User2 { get; set; }
        
    }
}
