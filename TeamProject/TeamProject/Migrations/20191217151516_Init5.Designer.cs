﻿// <auto-generated />
using System;
using FormGenerator.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TeamProject.Migrations
{
    [DbContext(typeof(FormGeneratorContext))]
    [Migration("20191217151516_Init5")]
    partial class Init5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("FormGenerator.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("Parent");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("FormGenerator.Models.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Field");
                });

            modelBuilder.Entity("FormGenerator.Models.FieldAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdAnswer");

                    b.Property<int>("IdField");

                    b.HasKey("Id");

                    b.ToTable("FieldAnswer");
                });

            modelBuilder.Entity("FormGenerator.Models.FormField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdField");

                    b.Property<int>("IdForm");

                    b.HasKey("Id");

                    b.ToTable("FormField");
                });

            modelBuilder.Entity("FormGenerator.Models.Forms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("id_Category");

                    b.HasKey("Id");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("FormGenerator.Models.Modele_pomocnicze.UserAnswerList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Id_User");

                    b.HasKey("Id");

                    b.ToTable("UserAnswerList");
                });

            modelBuilder.Entity("TeamProject.Models.FormGeneratorModels.Answers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.HasKey("Id");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("TeamProject.Models.FormGeneratorModels.UserAnswers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<int>("IdField");

                    b.Property<int>("IdForm");

                    b.Property<int>("IdUser");

                    b.Property<int?>("UserAnswerListId");

                    b.HasKey("Id");

                    b.HasIndex("UserAnswerListId");

                    b.ToTable("UserAnswers");
                });

            modelBuilder.Entity("TeamProject.Models.FormGeneratorModels.UserAnswers", b =>
                {
                    b.HasOne("FormGenerator.Models.Modele_pomocnicze.UserAnswerList")
                        .WithMany("user_answer_list")
                        .HasForeignKey("UserAnswerListId");
                });
#pragma warning restore 612, 618
        }
    }
}
