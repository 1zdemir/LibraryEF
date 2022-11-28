﻿// <auto-generated />
using System;
using KutuphaneEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KutuphaneEF.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KutuphaneEF.Models.Book", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Writer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ISBN");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("KutuphaneEF.Models.BookLocation", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("LibraryId")
                        .HasColumnType("int");

                    b.Property<byte>("Amount")
                        .HasColumnType("tinyint");

                    b.Property<string>("Cabinet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shelf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ISBN", "LibraryId");

                    b.HasIndex("LibraryId");

                    b.ToTable("BookLocations");
                });

            modelBuilder.Entity("KutuphaneEF.Models.City", b =>
                {
                    b.Property<byte>("PlateCode")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlateCode");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("KutuphaneEF.Models.District", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("Id"));

                    b.Property<byte>("CityId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("KutuphaneEF.Models.Employee", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LibraryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LibraryId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("KutuphaneEF.Models.Library", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookCount")
                        .HasColumnType("int");

                    b.Property<short>("Capacity")
                        .HasColumnType("smallint");

                    b.Property<short>("DistrictId")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("EstablishmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.ToTable("Libraries");
                });

            modelBuilder.Entity("KutuphaneEF.Models.BookLocation", b =>
                {
                    b.HasOne("KutuphaneEF.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("ISBN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KutuphaneEF.Models.Library", "Library")
                        .WithMany()
                        .HasForeignKey("LibraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Library");
                });

            modelBuilder.Entity("KutuphaneEF.Models.District", b =>
                {
                    b.HasOne("KutuphaneEF.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("KutuphaneEF.Models.Employee", b =>
                {
                    b.HasOne("KutuphaneEF.Models.Library", "Library")
                        .WithMany()
                        .HasForeignKey("LibraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Library");
                });

            modelBuilder.Entity("KutuphaneEF.Models.Library", b =>
                {
                    b.HasOne("KutuphaneEF.Models.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });
#pragma warning restore 612, 618
        }
    }
}
