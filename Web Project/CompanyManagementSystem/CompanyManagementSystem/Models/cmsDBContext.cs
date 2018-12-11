using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CompanyManagementSystem.Models
{
    public partial class cmsDBContext : DbContext
    {
        public DbSet<People> Person { get; set; }
        public DbSet<Project> Projects { get; set; }
        public cmsDBContext()
        {
        }

        public cmsDBContext(DbContextOptions<cmsDBContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-SN38H3G\\SQLEXPRESS;database=cmsDB;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}
