﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PriseEnMain.Data;

namespace PriseEnMain.Migrations
{
    [DbContext(typeof(PartengContext))]
    [Migration("20210117225556_quatre")]
    partial class quatre
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("PriseEnMain.Models.Attribut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Attributs");
                });

            modelBuilder.Entity("PriseEnMain.Models.Contrat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contrats");
                });

            modelBuilder.Entity("PriseEnMain.Models.Emetteur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Emetteurs");
                });

            modelBuilder.Entity("PriseEnMain.Models.Instrument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("attributId")
                        .HasColumnType("int");

                    b.Property<int?>("contratId")
                        .HasColumnType("int");

                    b.Property<int?>("emetteurId")
                        .HasColumnType("int");

                    b.Property<int?>("typeInstrumentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("attributId");

                    b.HasIndex("contratId");

                    b.HasIndex("emetteurId");

                    b.HasIndex("typeInstrumentId");

                    b.ToTable("Instruments");
                });

            modelBuilder.Entity("PriseEnMain.Models.InstrumentSous_jacent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("InstrumentSous_jacents");
                });

            modelBuilder.Entity("PriseEnMain.Models.TypeInstrument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeInstruments");
                });

            modelBuilder.Entity("PriseEnMain.Models.Instrument", b =>
                {
                    b.HasOne("PriseEnMain.Models.Attribut", "attribut")
                        .WithMany()
                        .HasForeignKey("attributId");

                    b.HasOne("PriseEnMain.Models.Contrat", "contrat")
                        .WithMany()
                        .HasForeignKey("contratId");

                    b.HasOne("PriseEnMain.Models.Emetteur", "emetteur")
                        .WithMany()
                        .HasForeignKey("emetteurId");

                    b.HasOne("PriseEnMain.Models.TypeInstrument", "typeInstrument")
                        .WithMany()
                        .HasForeignKey("typeInstrumentId");

                    b.Navigation("attribut");

                    b.Navigation("contrat");

                    b.Navigation("emetteur");

                    b.Navigation("typeInstrument");
                });

            modelBuilder.Entity("PriseEnMain.Models.InstrumentSous_jacent", b =>
                {
                    b.HasOne("PriseEnMain.Models.TypeInstrument", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.Navigation("Type");
                });
#pragma warning restore 612, 618
        }
    }
}
