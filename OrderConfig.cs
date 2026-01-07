using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OneRelationDemo
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("T_Orders");
            builder.Property(a=>a.Address).HasMaxLength(100).IsRequired();
            builder.Property(a => a.Name).HasMaxLength(100).IsRequired();
            builder.HasOne<Delivery>(a => a.delivery)
                .WithOne(b => b.order)
                .HasForeignKey<Delivery>(b => b.OrderId);
        }
    }
}
