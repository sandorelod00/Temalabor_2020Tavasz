using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.DTOs;

namespace TémaLab.ViewComponents
{
    public class CompetitionViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(TémaLab.Data.DTOs.CompetitionDto competiton)
        { 
            return View(competiton);
        }
    }
}
