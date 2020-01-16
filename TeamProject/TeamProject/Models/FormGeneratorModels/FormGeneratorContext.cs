﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Models;
using TeamProject.Models.FormGeneratorModels;
using TeamProject.Models.Modele_pomocnicze;
using FormGenerator.Models.Modele_pomocnicze;
using TeamProject.Models.NewTypeAndValidation;

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
        public DbSet<Logs> Logs { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientForms> PatientForms { get; set; }
        public DbSet<FieldToForms> FieldToForms { get; set; }
        public DbSet<Field> Field { get; set; }
        public DbSet<Forms> Forms { get; set; }
        public DbSet<FormField> FormField { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Answers> Answers { get; set; }
        public DbSet<FieldAnswer> FieldAnswer { get; set; }
        public DbSet<UserAnswers> UserAnswers { get; set; }
        public DbSet<FormGenerator.Models.Modele_pomocnicze.UserAnswerList> UserAnswerList { get; set; }
        public DbSet<SelectFieldOptions> SelectFieldOptions { get; set; }
        public DbSet<Validation> Validations { get; set; }
        
    }
}
