using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneRelationDemo
{
    internal class DeliveryConfig:IEntityTypeConfiguration<Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.ToTable("T_Deliveries");
            builder.Property(a=>a.Number).HasMaxLength(100).IsRequired();
            builder.Property(a=>a.CompanyName).HasMaxLength(100).IsRequired();
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Id).ValueGeneratedOnAdd();
        }
    }
}
