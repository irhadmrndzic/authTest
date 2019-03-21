using CourseProjectApp.EntityModel;
using CourseProjectApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.DATA
{
    public class ProfileContext:IdentityDbContext<ApplicationUser>        //DbContext
    {

        public ProfileContext(DbContextOptions<ProfileContext> options) : base(options)
        {

        }

        //public DbSet<Login> Logins { get; set; }

        //public DbSet<Register> Registration { get; set; }

        public DbSet<Individual> Individuals{ get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Hobbies>Hobbies{ get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
         //builder.Entity<Individual>().ToTable("Individual"); // mapira ime u tabelu
        
           
        }
    }
}
