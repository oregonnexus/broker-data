// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com

using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OregonNexus.Broker.Domain;

namespace OregonNexus.Broker.Data.Configuration;

public class PayloadContentConfiguration : IEntityTypeConfiguration<PayloadContent>
{
    public void Configure(EntityTypeBuilder<PayloadContent> builder)
    {   
        // Rename ID
        builder.Property(i => i.Id).HasColumnName("PayloadContentId");

        // Set to xml
        builder.Property(e => e.XmlContent)
            .HasConversion(
                xml => xml!.ToString(),
                xml => xml != null ? XElement.Parse(xml) : null)
            .HasColumnType("xml");
    }
}
