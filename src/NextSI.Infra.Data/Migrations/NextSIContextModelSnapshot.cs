﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NextSI.Infra.Data.Context;

namespace NextSI.Infra.Data.Migrations
{
    [DbContext(typeof(NextSIContext))]
    partial class NextSIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NextSI.Domain.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<DateTime>("BirthDate");

                    b.Property<DateTime?>("Deleted_at")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("Inserted_at")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a68dda48-7f88-46be-a008-b769a94b58e5"),
                            BirthDate = new DateTime(2019, 11, 1, 9, 29, 4, 98, DateTimeKind.Local).AddTicks(5523),
                            Email = "danielbuona@hotmail.com",
                            Inserted_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Daniel Buona"
                        });
                });

            modelBuilder.Entity("NextSI.Domain.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<DateTime?>("Deleted_at")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("Inserted_at")
                        .HasColumnType("datetime");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Phone");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e580fb9f-72bf-42bc-aba7-0f785458f47c"),
                            Email = "super.admin@nextsi.com.br",
                            FirstName = "Super",
                            Inserted_at = new DateTime(2019, 11, 1, 9, 29, 4, 91, DateTimeKind.Local).AddTicks(2577),
                            LastName = "Admin",
                            Password = "36n54v6CzXkFI0A7GjbH1MmI/FjeoRLDzKMpKT6ed60="
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
