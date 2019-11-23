﻿// <auto-generated />
using System;
using MOD.TrainingService.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MOD.TrainingService.Migrations
{
    [DbContext(typeof(TrainingContext))]
    [Migration("20191122104452_TrainingMIGc1")]
    partial class TrainingMIGc1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MOD.TrainingService.Models.Mentor", b =>
                {
                    b.Property<int>("MentorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("EndTime")
                        .HasColumnType("int");

                    b.Property<string>("LinkedIn")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<bool?>("MentorBlock")
                        .HasColumnType("bit");

                    b.Property<string>("MentorName")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<long>("MentorPhoneNo")
                        .HasColumnType("bigint");

                    b.Property<string>("MentorProfile")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("PrimaryTechnology")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<int>("StartTime")
                        .HasColumnType("int");

                    b.Property<int>("experience")
                        .HasColumnType("int");

                    b.HasKey("MentorID");

                    b.ToTable("Mentor");
                });

            modelBuilder.Entity("MOD.TrainingService.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("MentorId")
                        .HasColumnType("int");

                    b.Property<int>("Mentor_Amount")
                        .HasColumnType("int");

                    b.Property<int>("TrainingId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("MentorId");

                    b.HasIndex("TrainingId");

                    b.HasIndex("UserId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("MOD.TrainingService.Models.Technology", b =>
                {
                    b.Property<int>("TechID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Fees")
                        .HasColumnType("float");

                    b.Property<string>("TOC")
                        .IsRequired()
                        .HasColumnName("TOC")
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("TechnologyName")
                        .IsRequired()
                        .HasColumnName("TechnologyName")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("duration")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TechID");

                    b.ToTable("Technology");
                });

            modelBuilder.Entity("MOD.TrainingService.Models.Training", b =>
                {
                    b.Property<int>("TrainingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EndTime")
                        .HasColumnType("int");

                    b.Property<int>("MentorID")
                        .HasColumnType("int");

                    b.Property<int>("Progress")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StartTime")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechnologyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UID")
                        .HasColumnType("int");

                    b.Property<string>("rating")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainingID");

                    b.HasIndex("MentorID");

                    b.HasIndex("UID");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("MOD.TrainingService.Models.User", b =>
                {
                    b.Property<int>("UID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("UserBlock")
                        .HasColumnType("bit");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<long>("UserPhoneNo")
                        .HasColumnType("bigint");

                    b.HasKey("UID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MOD.TrainingService.Models.Payment", b =>
                {
                    b.HasOne("MOD.TrainingService.Models.Mentor", "Mentor")
                        .WithMany("Payment")
                        .HasForeignKey("MentorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MOD.TrainingService.Models.Training", "Training")
                        .WithMany("Payments")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MOD.TrainingService.Models.User", "user")
                        .WithMany("Payment")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MOD.TrainingService.Models.Training", b =>
                {
                    b.HasOne("MOD.TrainingService.Models.Mentor", "Mentor")
                        .WithMany("Training")
                        .HasForeignKey("MentorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MOD.TrainingService.Models.User", "user")
                        .WithMany("Training")
                        .HasForeignKey("UID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
