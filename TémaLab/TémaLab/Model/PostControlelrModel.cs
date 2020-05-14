using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.DTOs;
using TémaLab.Data.Entities;

namespace TémaLab.Model
{
    public class PostControlelrModel
    {
        public PostDto post { get; set; }
        public User? LoggedUser { get; set; }
        public PostControlelrModel(PostDto post, User? user)
        {
            this.post = post;
            this.LoggedUser = user;
        }
    }
}
