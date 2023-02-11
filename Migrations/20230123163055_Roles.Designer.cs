﻿// <auto-generated />
using System;
using BoraIlkProje2.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BoraIlkProje2.Migrations
{
    [DbContext(typeof(OrderDbContext))]
    [Migration("20230123163055_Roles")]
    partial class Roles
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BoraIlkProje2.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a5de80c4-3b13-4ef6-9314-5c28d1c771ab",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "01253-943073",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Thomas"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "36e7e9f6-4014-4ed8-b1b1-b9d105230e4d",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "01642-279328",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Josiah"
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "60360243-506d-4b9d-89b0-540b97af9e80",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "01839-461557",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Connor"
                        },
                        new
                        {
                            Id = 4,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6963dc70-3d91-4103-bf3c-cdcd49bd3a1b",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "01229-041462",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Ava"
                        },
                        new
                        {
                            Id = 5,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0747590a-fec6-40c2-a20a-303d62bfd926",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "01295-261611",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Brandon"
                        },
                        new
                        {
                            Id = 6,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7397f022-92b2-4d3d-9680-ddc26680d867",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "01051-013689",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Carter"
                        },
                        new
                        {
                            Id = 7,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0fe30c81-1bbd-4542-bd85-8fb00a2cc97a",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "01267-894495",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Sophia"
                        },
                        new
                        {
                            Id = 8,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "34c07315-31ac-4cbf-8a16-b6f77bf43a73",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "01946-077280",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Josiah"
                        },
                        new
                        {
                            Id = 9,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d9a20c47-578f-440a-b861-149f106e8ef4",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "01740-893556",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Brooklyn"
                        });
                });

            modelBuilder.Entity("BoraIlkProje2.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Ouantity")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppUserId = 0,
                            CreatedDate = new DateTime(2020, 10, 10, 11, 25, 16, 0, DateTimeKind.Unspecified).AddTicks(8758),
                            Ouantity = 59,
                            Price = 1729
                        },
                        new
                        {
                            Id = 2,
                            AppUserId = 0,
                            CreatedDate = new DateTime(1978, 8, 15, 1, 45, 51, 649, DateTimeKind.Unspecified).AddTicks(5176),
                            Ouantity = 1,
                            Price = 1392
                        },
                        new
                        {
                            Id = 3,
                            AppUserId = 0,
                            CreatedDate = new DateTime(2001, 5, 20, 6, 11, 55, 86, DateTimeKind.Unspecified).AddTicks(6744),
                            Ouantity = 26,
                            Price = 1615
                        },
                        new
                        {
                            Id = 4,
                            AppUserId = 0,
                            CreatedDate = new DateTime(2017, 8, 7, 7, 16, 31, 827, DateTimeKind.Unspecified).AddTicks(8994),
                            Ouantity = 70,
                            Price = 1828
                        },
                        new
                        {
                            Id = 5,
                            AppUserId = 0,
                            CreatedDate = new DateTime(1984, 1, 29, 16, 9, 28, 888, DateTimeKind.Unspecified).AddTicks(710),
                            Ouantity = 82,
                            Price = 1017
                        },
                        new
                        {
                            Id = 6,
                            AppUserId = 0,
                            CreatedDate = new DateTime(2007, 5, 25, 14, 49, 50, 257, DateTimeKind.Unspecified).AddTicks(8038),
                            Ouantity = 17,
                            Price = 1991
                        },
                        new
                        {
                            Id = 7,
                            AppUserId = 0,
                            CreatedDate = new DateTime(2012, 10, 9, 17, 12, 57, 90, DateTimeKind.Unspecified).AddTicks(3456),
                            Ouantity = 61,
                            Price = 1188
                        },
                        new
                        {
                            Id = 8,
                            AppUserId = 0,
                            CreatedDate = new DateTime(1977, 3, 5, 20, 45, 15, 62, DateTimeKind.Unspecified).AddTicks(9552),
                            Ouantity = 82,
                            Price = 1997
                        },
                        new
                        {
                            Id = 9,
                            AppUserId = 0,
                            CreatedDate = new DateTime(1997, 6, 30, 13, 2, 18, 916, DateTimeKind.Unspecified).AddTicks(4138),
                            Ouantity = 9,
                            Price = 1912
                        });
                });

            modelBuilder.Entity("BoraIlkProje2.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("BoraIlkProje2.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 8393m,
                            ProductName = "Nash CIO"
                        },
                        new
                        {
                            Id = 2,
                            Price = 6953m,
                            ProductName = "Jones Ltd"
                        },
                        new
                        {
                            Id = 3,
                            Price = 9559m,
                            ProductName = "Walker Ccc"
                        },
                        new
                        {
                            Id = 4,
                            Price = 6225m,
                            ProductName = "Osborne Cyf"
                        },
                        new
                        {
                            Id = 5,
                            Price = 7999m,
                            ProductName = "Davies Co-Operative"
                        },
                        new
                        {
                            Id = 6,
                            Price = 6797m,
                            ProductName = "Naylor General Partnership"
                        },
                        new
                        {
                            Id = 7,
                            Price = 8737m,
                            ProductName = "Cullen and Sons"
                        },
                        new
                        {
                            Id = 8,
                            Price = 7892m,
                            ProductName = "White Incorporated"
                        },
                        new
                        {
                            Id = 9,
                            Price = 5470m,
                            ProductName = "Schofield Cyf"
                        });
                });

            modelBuilder.Entity("BoraIlkProje2.Models.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BoraIlkProje2.Models.OrderDetail", b =>
                {
                    b.HasOne("BoraIlkProje2.Models.Order", null)
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoraIlkProje2.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("BoraIlkProje2.Models.Roles", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("BoraIlkProje2.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("BoraIlkProje2.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("BoraIlkProje2.Models.Roles", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoraIlkProje2.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("BoraIlkProje2.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BoraIlkProje2.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}