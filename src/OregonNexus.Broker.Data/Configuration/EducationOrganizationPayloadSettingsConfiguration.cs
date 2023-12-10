// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OregonNexus.Broker.Domain;

namespace OregonNexus.Broker.Data.Configuration;

public class EducationOrganizationPayloadSettingsConfiguration : IEntityTypeConfiguration<EducationOrganizationPayloadSettings>
{
    public void Configure(EntityTypeBuilder<EducationOrganizationPayloadSettings> builder)
    {   
        // Rename ID to UserId
        builder.Property(i => i.Id).HasColumnName("EducationOrganizationPayloadSettingsId");

        // Settings is json
        builder.OwnsMany(i => i.Settings).ToJson();

        // Create unique key constraint for EducationOrganizationid and UserId
        builder.HasIndex(x => new { x.EducationOrganizationId, x.Payload } ).IsUnique();
    }
}
