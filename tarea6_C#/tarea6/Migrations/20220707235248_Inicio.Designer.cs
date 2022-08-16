﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace tarea6.Migrations
{
    [DbContext(typeof(covidContext))]
    [Migration("20220707235248_Inicio")]
    partial class Inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Proceso", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("Personaid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Provicniaid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Vacunaid")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("Personaid");

                    b.HasIndex("Provicniaid");

                    b.HasIndex("Vacunaid");

                    b.ToTable("procesos");
                });

            modelBuilder.Entity("Provicnia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Nombre")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("provicnias");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Provicnia");
                });

            modelBuilder.Entity("Vacuna", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Nombre")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("vacunas");
                });

            modelBuilder.Entity("Persona", b =>
                {
                    b.HasBaseType("Provicnia");

                    b.Property<int>("Apellido")
                        .HasColumnType("INTEGER");

                    b.Property<int>("cedula")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Persona");
                });

            modelBuilder.Entity("Proceso", b =>
                {
                    b.HasOne("Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("Personaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Provicnia", "Provicnia")
                        .WithMany()
                        .HasForeignKey("Provicniaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vacuna", "Vacuna")
                        .WithMany()
                        .HasForeignKey("Vacunaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");

                    b.Navigation("Provicnia");

                    b.Navigation("Vacuna");
                });
#pragma warning restore 612, 618
        }
    }
}