﻿// <auto-generated />
using Hospital_Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital_Web.Migrations
{
    [DbContext(typeof(MenuContext))]
    [Migration("20240910060834_Initial migration")]
    partial class Initialmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hospital_Web.Models.Dish", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            id = 1,
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTfMhxMPgFmcc_yYgHJ_odtNReUO1h2bTBtrq3icPHGWw_cHUVwihJqOIhTrV9-l1_g5-c&usqp=CAU",
                            Name = "Margherita",
                            Price = 7.5
                        });
                });

            modelBuilder.Entity("Hospital_Web.Models.DishIngredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.HasKey("IngredientId", "DishId");

                    b.HasIndex("DishId");

                    b.ToTable("DishIngredients");

                    b.HasData(
                        new
                        {
                            IngredientId = 1,
                            DishId = 1,
                            id = 0
                        },
                        new
                        {
                            IngredientId = 2,
                            DishId = 1,
                            id = 0
                        });
                });

            modelBuilder.Entity("Hospital_Web.Models.Ingredient", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Name = "Tomato Sauce"
                        },
                        new
                        {
                            id = 2,
                            Name = "Mozzarella"
                        });
                });

            modelBuilder.Entity("Hospital_Web.Models.DishIngredient", b =>
                {
                    b.HasOne("Hospital_Web.Models.Dish", "Dish")
                        .WithMany("DishIngredients")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital_Web.Models.Ingredient", "Ingredient")
                        .WithMany("DishIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("Hospital_Web.Models.Dish", b =>
                {
                    b.Navigation("DishIngredients");
                });

            modelBuilder.Entity("Hospital_Web.Models.Ingredient", b =>
                {
                    b.Navigation("DishIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
