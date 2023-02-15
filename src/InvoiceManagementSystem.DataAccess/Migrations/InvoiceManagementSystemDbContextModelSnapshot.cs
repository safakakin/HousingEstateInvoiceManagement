﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RezervationSystem.DataAccess.Contexts;

#nullable disable

namespace InvoiceManagementSystem.DataAccess.Migrations
{
    [DbContext(typeof(InvoiceManagementSystemDbContext))]
    partial class InvoiceManagementSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            RoleName = "Customer"
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<string>("TC")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "asdfasd1@hotmail.com",
                            FirstName = "Ahmet",
                            LastName = "Safak",
                            PasswordHash = new byte[] { 237, 17, 221, 176, 91, 58, 133, 231, 227, 43, 144, 159, 146, 155, 181, 110, 115, 156, 12, 142, 79, 88, 39, 252, 128, 78, 82, 180, 162, 205, 203, 220, 65, 13, 251, 26, 175, 174, 25, 97, 129, 201, 38, 181, 212, 217, 8, 254, 94, 149, 235, 86, 175, 188, 176, 114, 239, 58, 103, 61, 248, 174, 109, 36 },
                            PasswordSalt = new byte[] { 13, 247, 44, 78, 30, 34, 48, 221, 91, 139, 178, 245, 243, 125, 158, 110, 100, 185, 177, 222, 232, 44, 105, 215, 115, 124, 54, 137, 134, 5, 126, 196, 34, 125, 146, 166, 193, 191, 167, 205, 229, 62, 127, 223, 205, 103, 27, 19, 120, 142, 53, 211, 180, 69, 106, 214, 158, 153, 134, 72, 190, 240, 18, 4, 255, 73, 230, 128, 172, 148, 84, 76, 60, 151, 36, 164, 19, 46, 99, 231, 255, 107, 33, 239, 39, 196, 200, 63, 37, 86, 215, 12, 69, 22, 29, 183, 50, 202, 26, 92, 237, 234, 56, 156, 220, 74, 47, 121, 232, 229, 7, 61, 41, 17, 212, 4, 228, 116, 120, 42, 143, 75, 38, 72, 110, 74, 11, 73 },
                            PhoneNumber = "5320000000",
                            Plate = "61 AC 61",
                            RoleId = 1,
                            TC = "11111111111"
                        },
                        new
                        {
                            Id = 2,
                            Email = "asdfasd2@hotmail.com",
                            FirstName = "Koc",
                            LastName = "Soy",
                            PasswordHash = new byte[] { 237, 17, 221, 176, 91, 58, 133, 231, 227, 43, 144, 159, 146, 155, 181, 110, 115, 156, 12, 142, 79, 88, 39, 252, 128, 78, 82, 180, 162, 205, 203, 220, 65, 13, 251, 26, 175, 174, 25, 97, 129, 201, 38, 181, 212, 217, 8, 254, 94, 149, 235, 86, 175, 188, 176, 114, 239, 58, 103, 61, 248, 174, 109, 36 },
                            PasswordSalt = new byte[] { 13, 247, 44, 78, 30, 34, 48, 221, 91, 139, 178, 245, 243, 125, 158, 110, 100, 185, 177, 222, 232, 44, 105, 215, 115, 124, 54, 137, 134, 5, 126, 196, 34, 125, 146, 166, 193, 191, 167, 205, 229, 62, 127, 223, 205, 103, 27, 19, 120, 142, 53, 211, 180, 69, 106, 214, 158, 153, 134, 72, 190, 240, 18, 4, 255, 73, 230, 128, 172, 148, 84, 76, 60, 151, 36, 164, 19, 46, 99, 231, 255, 107, 33, 239, 39, 196, 200, 63, 37, 86, 215, 12, 69, 22, 29, 183, 50, 202, 26, 92, 237, 234, 56, 156, 220, 74, 47, 121, 232, 229, 7, 61, 41, 17, 212, 4, 228, 116, 120, 42, 143, 75, 38, 72, 110, 74, 11, 73 },
                            PhoneNumber = "5320000001",
                            Plate = "61 AC 62",
                            RoleId = 2,
                            TC = "11111111112"
                        },
                        new
                        {
                            Id = 3,
                            Email = "asdfasd3@hotmail.com",
                            FirstName = "Zafer",
                            LastName = "Kara",
                            PasswordHash = new byte[] { 237, 17, 221, 176, 91, 58, 133, 231, 227, 43, 144, 159, 146, 155, 181, 110, 115, 156, 12, 142, 79, 88, 39, 252, 128, 78, 82, 180, 162, 205, 203, 220, 65, 13, 251, 26, 175, 174, 25, 97, 129, 201, 38, 181, 212, 217, 8, 254, 94, 149, 235, 86, 175, 188, 176, 114, 239, 58, 103, 61, 248, 174, 109, 36 },
                            PasswordSalt = new byte[] { 13, 247, 44, 78, 30, 34, 48, 221, 91, 139, 178, 245, 243, 125, 158, 110, 100, 185, 177, 222, 232, 44, 105, 215, 115, 124, 54, 137, 134, 5, 126, 196, 34, 125, 146, 166, 193, 191, 167, 205, 229, 62, 127, 223, 205, 103, 27, 19, 120, 142, 53, 211, 180, 69, 106, 214, 158, 153, 134, 72, 190, 240, 18, 4, 255, 73, 230, 128, 172, 148, 84, 76, 60, 151, 36, 164, 19, 46, 99, 231, 255, 107, 33, 239, 39, 196, 200, 63, 37, 86, 215, 12, 69, 22, 29, 183, 50, 202, 26, 92, 237, 234, 56, 156, 220, 74, 47, 121, 232, 229, 7, 61, 41, 17, 212, 4, 228, 116, 120, 42, 143, 75, 38, 72, 110, 74, 11, 73 },
                            PhoneNumber = "5320000002",
                            Plate = "61 AC 63",
                            RoleId = 2,
                            TC = "11111111113"
                        });
                });

            modelBuilder.Entity("RezervationSystem.Entity.Concrete.Apartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BlockID")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CustomerID")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Floor")
                        .HasColumnType("integer");

                    b.Property<bool>("IsEmpty")
                        .HasColumnType("boolean");

                    b.Property<int>("StyleID")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("BlockID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("StyleID");

                    b.ToTable("Apartments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BlockID = 1,
                            CustomerID = 1,
                            Floor = 18,
                            IsEmpty = true,
                            StyleID = 1
                        },
                        new
                        {
                            Id = 2,
                            BlockID = 2,
                            CustomerID = 2,
                            Floor = 19,
                            IsEmpty = true,
                            StyleID = 2
                        },
                        new
                        {
                            Id = 3,
                            BlockID = 3,
                            CustomerID = 3,
                            Floor = 20,
                            IsEmpty = true,
                            StyleID = 3
                        });
                });

            modelBuilder.Entity("RezervationSystem.Entity.Concrete.Block", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Blocks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "A Block"
                        },
                        new
                        {
                            Id = 2,
                            Name = "B Block"
                        },
                        new
                        {
                            Id = 3,
                            Name = "C Block"
                        });
                });

            modelBuilder.Entity("RezervationSystem.Entity.Concrete.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Balance")
                        .HasColumnType("integer");

                    b.Property<int>("CardNumber")
                        .HasColumnType("integer");

                    b.Property<int>("CardPassword")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CustomerID")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CustomerID");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Balance = 3000,
                            CardNumber = 11223344,
                            CardPassword = 1234,
                            CustomerID = 1
                        },
                        new
                        {
                            Id = 2,
                            Balance = 4000,
                            CardNumber = 11112222,
                            CardPassword = 4321,
                            CustomerID = 2
                        },
                        new
                        {
                            Id = 3,
                            Balance = 5000,
                            CardNumber = 33334444,
                            CardPassword = 1221,
                            CustomerID = 3
                        });
                });

            modelBuilder.Entity("RezervationSystem.Entity.Concrete.Debt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ApartmentID")
                        .HasColumnType("integer");

                    b.Property<int>("Cost")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CustomerID")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Debts");
                });

            modelBuilder.Entity("RezervationSystem.Entity.Concrete.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CustomerID")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("WrotenMessage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CustomerID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("RezervationSystem.Entity.Concrete.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ApartmentID")
                        .HasColumnType("integer");

                    b.Property<int>("CardId")
                        .HasColumnType("integer");

                    b.Property<int>("Cost")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CustomerID")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentID");

                    b.HasIndex("CardId");

                    b.HasIndex("CustomerID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("RezervationSystem.Entity.Concrete.Style", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Styles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "1+1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "2+1"
                        },
                        new
                        {
                            Id = 3,
                            Name = "3+1"
                        },
                        new
                        {
                            Id = 4,
                            Name = "4+1"
                        },
                        new
                        {
                            Id = 5,
                            Name = "5+1"
                        });
                });

            modelBuilder.Entity("RezervationSystem.Entity.Concrete.Apartment", b =>
                {
                    b.HasOne("RezervationSystem.Entity.Concrete.Block", "Block")
                        .WithMany()
                        .HasForeignKey("BlockID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Concrete.User", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RezervationSystem.Entity.Concrete.Style", "Style")
                        .WithMany()
                        .HasForeignKey("StyleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Block");

                    b.Navigation("Customer");

                    b.Navigation("Style");
                });

            modelBuilder.Entity("RezervationSystem.Entity.Concrete.Card", b =>
                {
                    b.HasOne("Core.Entities.Concrete.User", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("RezervationSystem.Entity.Concrete.Debt", b =>
                {
                    b.HasOne("RezervationSystem.Entity.Concrete.Apartment", "Apartment")
                        .WithMany()
                        .HasForeignKey("ApartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Concrete.User", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Apartment");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("RezervationSystem.Entity.Concrete.Message", b =>
                {
                    b.HasOne("Core.Entities.Concrete.User", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("RezervationSystem.Entity.Concrete.Payment", b =>
                {
                    b.HasOne("RezervationSystem.Entity.Concrete.Apartment", "Apartment")
                        .WithMany()
                        .HasForeignKey("ApartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RezervationSystem.Entity.Concrete.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Concrete.User", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Apartment");

                    b.Navigation("Card");

                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
