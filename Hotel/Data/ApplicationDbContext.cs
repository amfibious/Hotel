using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hotel.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Room>()
                .HasIndex(r => new { r.RoomId, r.FloorNumber })
                .IsUnique();
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}