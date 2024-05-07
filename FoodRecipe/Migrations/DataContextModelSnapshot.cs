﻿// <auto-generated />
using System;
using FoodRecipe.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodRecipe.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FoodRecipe.Entities.AlergicMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaterialId");

                    b.HasIndex("UserId");

                    b.ToTable("AlergicMaterials");
                });

            modelBuilder.Entity("FoodRecipe.Entities.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("FoodRecipe.Entities.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("FoodRecipe.Entities.Reciepe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FoodId")
                        .HasColumnType("int");

                    b.Property<int?>("MaterialId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("MaterialId");

                    b.ToTable("Reciepes");
                });

            modelBuilder.Entity("FoodRecipe.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FoodRecipe.Entities.AlergicMaterial", b =>
                {
                    b.HasOne("FoodRecipe.Entities.Material", null)
                        .WithMany("AlergicMaterials")
                        .HasForeignKey("MaterialId");

                    b.HasOne("FoodRecipe.Entities.User", null)
                        .WithMany("AlergicMaterials")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FoodRecipe.Entities.Reciepe", b =>
                {
                    b.HasOne("FoodRecipe.Entities.Food", null)
                        .WithMany("Reciepes")
                        .HasForeignKey("FoodId");

                    b.HasOne("FoodRecipe.Entities.Material", null)
                        .WithMany("Reciepes")
                        .HasForeignKey("MaterialId");
                });

            modelBuilder.Entity("FoodRecipe.Entities.Food", b =>
                {
                    b.Navigation("Reciepes");
                });

            modelBuilder.Entity("FoodRecipe.Entities.Material", b =>
                {
                    b.Navigation("AlergicMaterials");

                    b.Navigation("Reciepes");
                });

            modelBuilder.Entity("FoodRecipe.Entities.User", b =>
                {
                    b.Navigation("AlergicMaterials");
                });
#pragma warning restore 612, 618
        }
    }
}
