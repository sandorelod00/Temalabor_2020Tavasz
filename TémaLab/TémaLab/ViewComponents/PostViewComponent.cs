using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.DTOs;
using TémaLab.Data.Services;
using TémaLab.Data.Entities;
using TémaLab.Model;

namespace TémaLab.ViewComponents
{
    public class PostViewComponent : ViewComponent
    {

        private PostControlelrModel postModel;



        public IViewComponentResult Invoke(PostDto post, User? User)
        {
            postModel = new PostControlelrModel(post, User);
            return View(postModel);
        }
    }
}
