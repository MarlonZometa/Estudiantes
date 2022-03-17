﻿// <auto-generated />
using System;
using CRUDOperationsDemo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Estudiantes.Migrations
{
    [DbContext(typeof(CRUDDbContext))]
    partial class CRUDDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CURDOprationsDimo.Models.Carrera", b =>
                {
                    b.Property<int>("CarreraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarreraId"), 1L, 1);

                    b.Property<string>("CarreraName")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("CarreraId");

                    b.ToTable("Carrera", "HR");
                });

            modelBuilder.Entity("CURDOprationsDimo.Models.Estudiantes", b =>
                {
                    b.Property<int?>("EstudiantesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("EstudiantesId"), 1L, 1);

                    b.Property<int>("CarreraId")
                        .HasColumnType("int");

                    b.Property<string>("EstudiantesLastName")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("EstudiantesName")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("EstudiantesId");

                    b.HasIndex("CarreraId");

                    b.ToTable("Estudiantes", "HR");
                });

            modelBuilder.Entity("CURDOprationsDimo.Models.Estudiantes", b =>
                {
                    b.HasOne("CURDOprationsDimo.Models.Carrera", "Carrera")
                        .WithMany()
                        .HasForeignKey("CarreraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrera");
                });
#pragma warning restore 612, 618
        }
    }
}
