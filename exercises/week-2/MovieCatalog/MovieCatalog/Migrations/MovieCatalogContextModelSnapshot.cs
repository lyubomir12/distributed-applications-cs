﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieCatalog.Models;

namespace MovieCatalog.Migrations
{
    [DbContext(typeof(MovieCatalogContext))]
    partial class MovieCatalogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieCatalog.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasMaxLength(300);

                    b.Property<string>("Description")
                        .HasMaxLength(4000);

                    b.Property<string>("Genre")
                        .HasMaxLength(15);

                    b.Property<int?>("RatingId");

                    b.Property<DateTime?>("ReleaseDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("RatingId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("MovieCatalog.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RatingValue")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.HasKey("Id");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("MovieCatalog.Models.Movie", b =>
                {
                    b.HasOne("MovieCatalog.Models.Rating", "Rating")
                        .WithMany("Movies")
                        .HasForeignKey("RatingId");
                });
#pragma warning restore 612, 618
        }
    }
}