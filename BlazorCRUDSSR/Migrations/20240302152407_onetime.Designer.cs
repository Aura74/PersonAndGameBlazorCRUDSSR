﻿// <auto-generated />
using System;
using BlazorCRUDSSR.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorCRUDSSR.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240302152407_onetime")]
    partial class onetime
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorCRUDSSR.Models.VideoGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VideoGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Publisher = "CD Project",
                            ReleaseYear = 1998,
                            Title = "CyberPunk"
                        },
                        new
                        {
                            Id = 2,
                            Publisher = "XXXXXXRE",
                            ReleaseYear = 1999,
                            Title = "ElderRing"
                        },
                        new
                        {
                            Id = 3,
                            Publisher = "Nintendo",
                            ReleaseYear = 1988,
                            Title = "Zelda"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
