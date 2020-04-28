﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.SeedInterfaces;
using TémaLab.Data.Users;

namespace TémaLab.Data.SeedService
{
    public class RoleSeedService : IRoleSeedService
    {
        private readonly RoleManager<IdentityRole<int>> _roleManager; 
        public RoleSeedService(RoleManager<IdentityRole<int>> roleManager) => 
            _roleManager = roleManager; 
        public async Task SeedRoleAsync() 
        { 
            if (!await _roleManager.RoleExistsAsync(Roles.Administrators)) 
                await _roleManager.CreateAsync(new IdentityRole<int> { Name = Roles.Administrators }); 
        }
    }
}
