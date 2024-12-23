﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.DB;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(AsdDbContext))]
    [Migration("20241223093934_Patch1")]
    partial class Patch1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Global.Kullanici.Birimler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Acıklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Birimler");
                });

            modelBuilder.Entity("Domain.Entities.Global.Kullanici.Gorevler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Acıklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Gorevler");
                });

            modelBuilder.Entity("Domain.Entities.Global.Kullanici.Gruplar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Acıklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Gruplar");
                });

            modelBuilder.Entity("Domain.Entities.Global.Kullanici.Kullanicilar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Birim_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gorev")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gorev_Id")
                        .HasColumnType("int");

                    b.Property<int>("Grup_Id")
                        .HasColumnType("int");

                    b.Property<int?>("GruplarId")
                        .HasColumnType("int");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ProfilResmi")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SifreHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Birim_Id");

                    b.HasIndex("Gorev_Id");

                    b.HasIndex("GruplarId");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("Domain.Entities.Global.Modul.Menuler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Child_Id")
                        .HasColumnType("int");

                    b.Property<string>("ControllerAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Detail_Id")
                        .HasColumnType("int");

                    b.Property<int>("Master_Id")
                        .HasColumnType("int");

                    b.Property<string>("MenuAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuIkon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Modul_Id")
                        .HasColumnType("int");

                    b.Property<int>("SiraNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ViewAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("YetkilerId")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Modul_Id");

                    b.HasIndex("YetkilerId");

                    b.ToTable("Menuler");
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

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("YetkilerId")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("YetkilerId");

                    b.ToTable("Moduller");
                });

            modelBuilder.Entity("Domain.Entities.Global.Yetki.OnYuz_Yetkiler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Kullanici_GrupId")
                        .HasColumnType("int");

                    b.Property<int>("Modul_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("View_Id")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("OnYuz_Yetkiler");
                });

            modelBuilder.Entity("Domain.Entities.Global.Kullanici.Kullanicilar", b =>
                {
                    b.HasOne("Domain.Entities.Global.Kullanici.Birimler", "Birimler")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("Birim_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Global.Kullanici.Gorevler", "Gorevler")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("Gorev_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Global.Kullanici.Gruplar", "Gruplar")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("GruplarId");

                    b.Navigation("Birimler");

                    b.Navigation("Gorevler");

                    b.Navigation("Gruplar");
                });

            modelBuilder.Entity("Domain.Entities.Global.Modul.Menuler", b =>
                {
                    b.HasOne("Domain.Entities.Global.Modul.Moduller", "Moduller")
                        .WithMany("Menuler")
                        .HasForeignKey("Modul_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Global.Yetki.OnYuz_Yetkiler", "Yetkiler")
                        .WithMany()
                        .HasForeignKey("YetkilerId");

                    b.Navigation("Moduller");

                    b.Navigation("Yetkiler");
                });

            modelBuilder.Entity("Domain.Entities.Global.Modul.Moduller", b =>
                {
                    b.HasOne("Domain.Entities.Global.Yetki.OnYuz_Yetkiler", "Yetkiler")
                        .WithMany()
                        .HasForeignKey("YetkilerId");

                    b.Navigation("Yetkiler");
                });

            modelBuilder.Entity("Domain.Entities.Global.Kullanici.Birimler", b =>
                {
                    b.Navigation("Kullanicilar");
                });

            modelBuilder.Entity("Domain.Entities.Global.Kullanici.Gorevler", b =>
                {
                    b.Navigation("Kullanicilar");
                });

            modelBuilder.Entity("Domain.Entities.Global.Kullanici.Gruplar", b =>
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
