using Chat.Web.Models;
using chatty.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Web.Data.Configurations
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("Rooms");

            builder.Property(room => room.Name).IsRequired().HasMaxLength(100);

            builder.HasOne(room => room.Admin)
                .WithMany(user => user.rooms)
                .IsRequired();
        }
    }
}