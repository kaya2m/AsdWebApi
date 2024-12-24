﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.DB;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(AsdDbContext))]
    partial class AsdDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Global.Kullanici.Departmanlar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Acıklama")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Adi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kod")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ANA_Departmanlar");
                });

            modelBuilder.Entity("Domain.Entities.Global.Kullanici.Gorevler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Acıklama")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Adi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmanId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DepartmanId");

                    b.ToTable("ANA_Gorevler");
                });

            modelBuilder.Entity("Domain.Entities.Global.Kullanici.Kullanicilar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmanId")
                        .HasColumnType("int");

                    b.Property<string>("Gorev")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("GorevId")
                        .HasColumnType("int");

                    b.Property<string>("KullaniciAdi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("ProfilResmi")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TC")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Tel")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DepartmanId");

                    b.HasIndex("GorevId");

                    b.ToTable("ANA_Kullanicilar");
                });

            modelBuilder.Entity("Domain.Entities.Global.Modul.Menuler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChildId")
                        .HasColumnType("int");

                    b.Property<string>("ControllerAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DetailId")
                        .HasColumnType("int");

                    b.Property<int>("MasterId")
                        .HasColumnType("int");

                    b.Property<string>("MenuAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuIkon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModulId")
                        .HasColumnType("int");

                    b.Property<int>("SiraNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ViewAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ModulId");

                    b.ToTable("ANA_Menuler");
                });

            modelBuilder.Entity("Domain.Entities.Global.Modul.Moduller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Acıklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModulAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModulIkon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModulRenk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModulURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ANA_Moduller");
                });

            modelBuilder.Entity("Domain.Entities.Global.Kullanici.Gorevler", b =>
                {
                    b.HasOne("Domain.Entities.Global.Kullanici.Departmanlar", "Departmanlar")
                        .WithMany("Gorevler")
                        .HasForeignKey("DepartmanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departmanlar");
                });

            modelBuilder.Entity("Domain.Entities.Global.Kullanici.Kullanicilar", b =>
                {
                    b.HasOne("Domain.Entities.Global.Kullanici.Departmanlar", "Departmanlar")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("DepartmanId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Global.Kullanici.Gorevler", "Gorevler")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("GorevId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Departmanlar");

                    b.Navigation("Gorevler");
                });

            modelBuilder.Entity("Domain.Entities.Global.Modul.Menuler", b =>
                {
                    b.HasOne("Domain.Entities.Global.Modul.Moduller", "Moduller")
                        .WithMany("Menuler")
                        .HasForeignKey("ModulId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Moduller");
                });

            modelBuilder.Entity("Domain.Entities.Global.Kullanici.Departmanlar", b =>
                {
                    b.Navigation("Gorevler");

                    b.Navigation("Kullanicilar");
                });

            modelBuilder.Entity("Domain.Entities.Global.Kullanici.Gorevler", b =>
                {
                    b.Navigation("Kullanicilar");
                });

            modelBuilder.Entity("Domain.Entities.Global.Modul.Moduller", b =>
                {
                    b.Navigation("Menuler");
                });
#pragma warning restore 612, 618
        }
    }
}
