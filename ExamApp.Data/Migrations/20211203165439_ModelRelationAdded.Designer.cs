﻿// <auto-generated />
using System;
using ExamApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExamApp.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211203165439_ModelRelationAdded")]
    partial class ModelRelationAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ExamApp.Core.Models.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("ExamApp.Core.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ExamId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ExamApp.Core.Models.QuestionOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Option")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("QuestionId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionOptions");
                });

            modelBuilder.Entity("ExamApp.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 123,
                            CreationDate = new DateTime(2021, 12, 3, 19, 54, 38, 840, DateTimeKind.Local).AddTicks(1437),
                            Password = "123",
                            Status = true,
                            UpdateDate = new DateTime(2021, 12, 3, 19, 54, 38, 840, DateTimeKind.Local).AddTicks(7219),
                            Username = "sa"
                        });
                });

            modelBuilder.Entity("ExamApp.Core.Models.Question", b =>
                {
                    b.HasOne("ExamApp.Core.Models.Exam", null)
                        .WithMany("Questions")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExamApp.Core.Models.QuestionOption", b =>
                {
                    b.HasOne("ExamApp.Core.Models.Question", "Question")
                        .WithMany("QuestionOptions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("ExamApp.Core.Models.Exam", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("ExamApp.Core.Models.Question", b =>
                {
                    b.Navigation("QuestionOptions");
                });
#pragma warning restore 612, 618
        }
    }
}
