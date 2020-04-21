﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.Entities;
using TémaLab.Data.SeedService;

namespace TémaLab.Data.EntityConfiguration
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        private readonly ISeedService _seedService;
        public UserEntityConfiguration(ISeedService seedService) => _seedService = seedService;
        public void Configure(EntityTypeBuilder<User> builder) => builder.HasData(_seedService.Users.Values);
    }
}
