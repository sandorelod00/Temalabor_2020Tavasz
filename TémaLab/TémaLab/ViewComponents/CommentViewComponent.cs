using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.Entities;
using TémaLab.Model;

namespace TémaLab.ViewComponents
{
    public class CommentViewComponent : ViewComponent
    {
        CommentControllerModel commentModel;
        public IViewComponentResult Invoke(Comment comment, User? user)
        {
            commentModel = new CommentControllerModel(comment, user);
            return View(commentModel);
        }
    }
}
