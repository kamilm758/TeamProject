using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Models;
using TeamProject.Models.Modele_pomocnicze;
namespace FormGenerator.Models
{
    public class FormGeneratorContext : DbContext
    {
        public FormGeneratorContext(DbContextOptions<FormGeneratorContext> options)
               : base(options)
        {

        }

        public FormGeneratorContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseNpgsql("Host=projekt1920.cakejnzadj5u.us-east-1.rds.amazonaws.com;Database=postgres;Username=postgres;Password=projekt.pb19_20");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Field> Field { get; set; }
        public DbSet<Forms> Froms { get; set; }
        public DbSet<FormField> FormField { get; set; }
        
    }
}
