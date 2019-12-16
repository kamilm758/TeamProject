using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FormGenerator.Models;

namespace TeamProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseNpgsql("Host=projekt1920.cakejnzadj5u.us-east-1.rds.amazonaws.com;Database=postgres;Username=postgres;Password=projekt.pb19_20");
            }
        }
        public DbSet<FormGenerator.Models.Field> Field { get; set; }
    }
}
