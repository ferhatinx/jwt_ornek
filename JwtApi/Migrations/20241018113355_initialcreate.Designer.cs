﻿// <auto-generated />
using System;
using JwtApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JwtApi.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20241018113355_initialcreate")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.35");

            modelBuilder.Entity("JwtApi.Data.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("JwtApi.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 25,
                            CreatedTime = new DateTime(2024, 10, 18, 11, 33, 55, 639, DateTimeKind.Utc).AddTicks(9326),
                            Name = "Ferhat"
                        },
                        new
                        {
                            Id = 2,
                            Age = 25,
                            CreatedTime = new DateTime(2024, 10, 18, 11, 33, 55, 639, DateTimeKind.Utc).AddTicks(9331),
                            Name = "Betül"
                        },
                        new
                        {
                            Id = 3,
                            Age = 30,
                            CreatedTime = new DateTime(2024, 10, 18, 11, 33, 55, 639, DateTimeKind.Utc).AddTicks(9331),
                            Name = "İlker"
                        });
                });

            modelBuilder.Entity("JwtApi.Data.User", b =>
                {
                    b.HasOne("JwtApi.Data.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("JwtApi.Data.Role", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
