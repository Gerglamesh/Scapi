﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SCAPI_Frontend.Context;

namespace SCAPI_Frontend.Migrations
{
    [DbContext(typeof(ScapiContext))]
    [Migration("20201003125103_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SCAPI_Frontend.Models.ChordModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BaseNote")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FretPosition")
                        .HasColumnType("int");

                    b.Property<int>("StartString")
                        .HasColumnType("int");

                    b.Property<string>("TriadType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Chords");
                });

            modelBuilder.Entity("SCAPI_Frontend.Models.ChordModel", b =>
                {
                    b.OwnsOne("SCAPI_Frontend.Models.ChordDiagramModel", "ChordDiagram", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("ChordModelId")
                                .HasColumnType("int");

                            b1.Property<string>("Path")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("Id");

                            b1.HasIndex("ChordModelId")
                                .IsUnique();

                            b1.ToTable("ChordDiagrams");

                            b1.WithOwner()
                                .HasForeignKey("ChordModelId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
