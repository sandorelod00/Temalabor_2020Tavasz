using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.Entities;

namespace TémaLab.Controllers
{
    
    public class AccountController : Controller
    {
        public AccountController(SignInManager<User> signInManager) 
        { 
            SignInManager = signInManager; 
        }
        public SignInManager<User> SignInManager { get; }
        
        [Route("Account/LogOut")]
        public async Task<IActionResult> LogOut() 
        {
            await SignInManager.SignOutAsync();
            return RedirectToPage("/Index"); 
        }
    }
}
