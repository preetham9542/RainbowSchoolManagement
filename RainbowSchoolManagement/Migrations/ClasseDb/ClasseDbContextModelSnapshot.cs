﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RainbowSchoolManagement.Data;

#nullable disable

namespace RainbowSchoolManagement.Migrations.ClasseDb
{
    [DbContext(typeof(ClasseDbContext))]
    partial class ClasseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RainbowSchoolManagement.Models.Classe", b =>
                {
                    b.Property<int>("class_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("class_id"), 1L, 1);

                    b.Property<string>("ClassLeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassSection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClassStrength")
                        .HasColumnType("int");

                    b.HasKey("class_id");

                    b.ToTable("Classe");
                });
#pragma warning restore 612, 618
        }
    }
}
