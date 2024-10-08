﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240918201351_ogretmenTable")]
    partial class ogretmenTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Concrete.Kurs", b =>
                {
                    b.Property<int>("KursID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KursID"));

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OgretmenID")
                        .HasColumnType("int");

                    b.HasKey("KursID");

                    b.HasIndex("OgretmenID");

                    b.ToTable("Kurslar");
                });

            modelBuilder.Entity("EntityLayer.Concrete.KursKayit", b =>
                {
                    b.Property<int>("KayitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KayitID"));

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KursID")
                        .HasColumnType("int");

                    b.Property<int>("OgrenciID")
                        .HasColumnType("int");

                    b.HasKey("KayitID");

                    b.HasIndex("KursID");

                    b.HasIndex("OgrenciID");

                    b.ToTable("KursKayitlari");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OgrenciID"));

                    b.Property<string>("Eposta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgrenciAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgrenciSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OgrenciID");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Ogretmen", b =>
                {
                    b.Property<int>("OgretmenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OgretmenID"));

                    b.Property<DateTime>("BaslamaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Eposta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgretmenAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgretmenSoyadi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OgretmenID");

                    b.ToTable("Ogretmenler");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Kurs", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Ogretmen", "Ogretmen")
                        .WithMany("Kurslar")
                        .HasForeignKey("OgretmenID");

                    b.Navigation("Ogretmen");
                });

            modelBuilder.Entity("EntityLayer.Concrete.KursKayit", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Kurs", "Kurs")
                        .WithMany("KursKayitlari")
                        .HasForeignKey("KursID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Ogrenci", "Ogrenci")
                        .WithMany("KursKayitlari")
                        .HasForeignKey("OgrenciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kurs");

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Kurs", b =>
                {
                    b.Navigation("KursKayitlari");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Ogrenci", b =>
                {
                    b.Navigation("KursKayitlari");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Ogretmen", b =>
                {
                    b.Navigation("Kurslar");
                });
#pragma warning restore 612, 618
        }
    }
}
