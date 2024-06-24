using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api.Models;
using api.Controllers;
using api2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace api2.Data
{
    public class ApplicationDBContext : IdentityDbContext<AppUser>
    {
        //this is a giant class that will allow you search individual tables, its gonna specify which table do we want
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
        //DbSet is for, Im gonna grab something out of the database and you need to do something with it
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"

                },
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"

                },
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }


    }
}