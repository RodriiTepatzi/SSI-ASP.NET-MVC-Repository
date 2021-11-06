using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SSI_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSI_WebApp.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<FixOrder_Picture>().HasKey(am => new
            {
                am.FixOrderId,
                am.PictureId
            });

            modelBuilder.Entity<FixOrder_Picture>().HasOne(m => m.FixOrder).WithMany(am => am.FixOrder_Pictures).HasForeignKey(m => m.FixOrderId);
            modelBuilder.Entity<FixOrder_Picture>().HasOne(m => m.Picture).WithMany(am => am.FixOrder_Pictures).HasForeignKey(m => m.PictureId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<FixOrder> FixOrders { get; set; }
    }
}
