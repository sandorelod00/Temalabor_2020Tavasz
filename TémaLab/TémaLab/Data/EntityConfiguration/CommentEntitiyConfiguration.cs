using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.Entities;
using TémaLab.Data.SeedService;

namespace TémaLab.Data.EntityConfiguration
{
    public class CommentEntitiyConfiguration : IEntityTypeConfiguration<Comment>
    {
        private readonly ISeedService _seedService;
        public CommentEntityConfiguration(ISeedService seedService) => _seedService = seedService;

        public void Configure(EntityTypeBuilder<Comment> builder) => builder.HasData(_seedService.Comments.Values);
    }
}
