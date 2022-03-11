﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220107000336_mg3")]
    partial class mg3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Expert", b =>
                {
                    b.Property<int>("ExpertID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ExpertAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpertBlog")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpertBranch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpertMenu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpertName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpertPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpertSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpertSocial2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpertSocial3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FoodStatus")
                        .HasColumnType("bit");

                    b.HasKey("ExpertID");

                    b.ToTable("Experts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Foods", b =>
                {
                    b.Property<int>("FoodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("FoodCalorie")
                        .HasColumnType("float");

                    b.Property<string>("FoodDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FoodFat")
                        .HasColumnType("float");

                    b.Property<string>("FoodImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FoodProtein")
                        .HasColumnType("float");

                    b.Property<bool>("FoodStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Foodamount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Foodcarbo")
                        .HasColumnType("float");

                    b.HasKey("FoodID");

                    b.ToTable("Foodss");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Profil", b =>
                {
                    b.Property<int>("ProfilID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FoodID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Saat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ProfilID");

                    b.ToTable("Profils");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UserDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("UserHeight")
                        .HasColumnType("float");

                    b.Property<string>("UserImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UserStatus")
                        .HasColumnType("bit");

                    b.Property<double>("UserWeight")
                        .HasColumnType("float");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
