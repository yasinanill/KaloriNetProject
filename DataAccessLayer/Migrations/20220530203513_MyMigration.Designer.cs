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
    [Migration("20220530203513_MyMigration")]
    partial class MyMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Cart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.CartItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.DailyRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RecordNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecordNote2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecordNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("recordDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("DailyRecords");
                });

            modelBuilder.Entity("EntityLayer.Concrete.DailyRecordItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Calorie")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("DailyRecordId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("recordId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DailyRecordId");

                    b.HasIndex("ProductId");

                    b.ToTable("DailyRecordItem");
                });

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

            modelBuilder.Entity("EntityLayer.Concrete.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Calorie")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Fat")
                        .HasColumnType("float");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Protein")
                        .HasColumnType("float");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("amount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("carbo")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ProductCategory", b =>
                {
                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("CategoryID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductCategory");
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

            modelBuilder.Entity("EntityLayer.Concrete.Recipes", b =>
                {
                    b.Property<int>("RecipesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FoodDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foodamount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RecipesCalorie")
                        .HasColumnType("float");

                    b.Property<string>("RecipesCook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RecipesDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("RecipesFat")
                        .HasColumnType("float");

                    b.Property<string>("RecipesImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipesMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipesMethod1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipesMethod2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipesMethod3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipesName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RecipesProtein")
                        .HasColumnType("float");

                    b.Property<bool>("RecipesStatus")
                        .HasColumnType("bit");

                    b.Property<double>("Recipescarbo")
                        .HasColumnType("float");

                    b.HasKey("RecipesID");

                    b.ToTable("Recipess");
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

            modelBuilder.Entity("EntityLayer.Concrete.CartItem", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EntityLayer.Concrete.DailyRecordItem", b =>
                {
                    b.HasOne("EntityLayer.Concrete.DailyRecord", "DailyRecord")
                        .WithMany("DailyRecordItem")
                        .HasForeignKey("DailyRecordId");

                    b.HasOne("EntityLayer.Concrete.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DailyRecord");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ProductCategory", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("productCategories")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Product", "Product")
                        .WithMany("productCategories")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Navigation("productCategories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.DailyRecord", b =>
                {
                    b.Navigation("DailyRecordItem");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Product", b =>
                {
                    b.Navigation("productCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
