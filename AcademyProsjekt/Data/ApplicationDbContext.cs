using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyProsjekt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Student> Student { get; set; }

        public DbSet<Models.Course> Course { get; set; }
        public DbSet<Models.Teacher> Teacher { get; set; }
        public DbSet<Models.Enrollment> Enrollment { get; set; }
        public DbSet<Models.Module> Module { get; set; }
        public DbSet<Models.Page> Page { get; set; }
        public DbSet<Models.Progress> Progress { get; set; }


    }
}
