﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroPrestamoBlazor.DAL;

namespace RegistroPrestamoBlazor.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("RegistroPrestamoBlazor.Models.Personas", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Balance")
                        .HasColumnType("REAL");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PersonaId");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("RegistroPrestamoBlazor.Models.Prestamos", b =>
                {
                    b.Property<int>("PrestamoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Balance")
                        .HasColumnType("REAL");

                    b.Property<string>("Concepto")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.Property<int>("PersonaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PrestamoId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Prestamos");
                });

            modelBuilder.Entity("RegistroPrestamoBlazor.Models.Prestamos", b =>
                {
                    b.HasOne("RegistroPrestamoBlazor.Models.Personas", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });
#pragma warning restore 612, 618
        }
    }
}
