// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OregonNexus.Broker.Domain;

namespace OregonNexus.Broker.Data.Configuration;

public class OutgoingRequestConfiguration : IEntityTypeConfiguration<OutgoingRequest>
{
    public void Configure(EntityTypeBuilder<OutgoingRequest> builder)
    {   
        // Rename ID
        builder.Property(i => i.Id).HasColumnName("OutgoingRequestId");
    }
}
