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
    public class CompetitionEntityConfiguration : IEntityTypeConfiguration<Competition>
    {
    private readonly ISeedService _seedService;
    public CompetitionEntityConfiguration(ISeedService seedService) => _seedService = seedService;

    public void Configure(EntityTypeBuilder<Competition> builder) => builder.HasData(_seedService.Competitions);
    }
}
