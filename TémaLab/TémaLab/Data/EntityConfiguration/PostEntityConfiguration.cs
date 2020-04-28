using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.Entities;
using TémaLab.Data.SeedInterfaces.SeedService;
using TémaLab.Data.SeedService;
namespace TémaLab.Data.EntityConfiguration
{
    public class PostEntityConfiguration : IEntityTypeConfiguration<Post>
    {
        private readonly ISeedService _seedService;
        public PostEntityConfiguration(ISeedService seedService) => _seedService = seedService;
        public void Configure(EntityTypeBuilder<Post> builder) => builder.HasData(_seedService.Posts.Values);
    }
}
