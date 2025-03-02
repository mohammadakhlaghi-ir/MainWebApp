﻿// <auto-generated />
using System;
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entity.Migrations
{
    [DbContext(typeof(MainDbContext))]
    partial class MainDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entity.Models.Permissions", b =>
                {
                    b.Property<int>("PermissionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PermissionID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PermissionName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PermissionID");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            PermissionID = 1,
                            Description = "Add New User To Context",
                            PermissionName = "Create Users"
                        },
                        new
                        {
                            PermissionID = 2,
                            Description = "Edit User Details",
                            PermissionName = "Edit Users"
                        },
                        new
                        {
                            PermissionID = 3,
                            Description = "Set IsDeleted True For Users Or Delete From Context",
                            PermissionName = "Delete Users"
                        },
                        new
                        {
                            PermissionID = 4,
                            Description = "View Details of Users",
                            PermissionName = "View Users"
                        },
                        new
                        {
                            PermissionID = 6,
                            Description = "Add New Role To Context",
                            PermissionName = "Create Roles"
                        },
                        new
                        {
                            PermissionID = 7,
                            Description = "Edit Roles Details",
                            PermissionName = "Edit Roles"
                        },
                        new
                        {
                            PermissionID = 8,
                            Description = "Set IsDeleted True For Roles Or Delete From Context",
                            PermissionName = "Delete Roles"
                        },
                        new
                        {
                            PermissionID = 9,
                            Description = "View Details of Roles",
                            PermissionName = "View Roles"
                        });
                });

            modelBuilder.Entity("Entity.Models.RolePermissions", b =>
                {
                    b.Property<int>("RolePermissionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RolePermissionID"));

                    b.Property<int>("PermissionID")
                        .HasColumnType("int");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.HasKey("RolePermissionID");

                    b.HasIndex("PermissionID");

                    b.HasIndex("RoleID");

                    b.ToTable("RolePermissions");

                    b.HasData(
                        new
                        {
                            RolePermissionID = 1,
                            PermissionID = 1,
                            RoleID = 1
                        },
                        new
                        {
                            RolePermissionID = 2,
                            PermissionID = 2,
                            RoleID = 1
                        },
                        new
                        {
                            RolePermissionID = 3,
                            PermissionID = 3,
                            RoleID = 1
                        },
                        new
                        {
                            RolePermissionID = 4,
                            PermissionID = 4,
                            RoleID = 1
                        },
                        new
                        {
                            RolePermissionID = 5,
                            PermissionID = 6,
                            RoleID = 1
                        },
                        new
                        {
                            RolePermissionID = 6,
                            PermissionID = 7,
                            RoleID = 1
                        },
                        new
                        {
                            RolePermissionID = 7,
                            PermissionID = 8,
                            RoleID = 1
                        },
                        new
                        {
                            RolePermissionID = 8,
                            PermissionID = 9,
                            RoleID = 1
                        });
                });

            modelBuilder.Entity("Entity.Models.Roles", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            CreatedDate = new DateTime(1999, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Administrator role",
                            IsDeleted = false,
                            RoleName = "Admin"
                        });
                });

            modelBuilder.Entity("Entity.Models.Users", b =>
                {
                    b.Property<long>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UserID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActived")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProfileImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserID");

                    b.HasIndex("RoleID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1L,
                            Address = "Address",
                            BirthDate = new DateTime(1999, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(1999, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "michaelsevii17@gmail.com",
                            FirstName = "First Name",
                            IsActived = true,
                            IsDeleted = false,
                            LastName = "Last Name",
                            Password = "1234",
                            PhoneNumber = "09378982060",
                            ProfileImage = "default.png",
                            RoleID = 1,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("Entity.Models.RolePermissions", b =>
                {
                    b.HasOne("Entity.Models.Permissions", "Permission")
                        .WithMany("RolePemission")
                        .HasForeignKey("PermissionID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entity.Models.Roles", "Role")
                        .WithMany("RolePemission")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Entity.Models.Users", b =>
                {
                    b.HasOne("Entity.Models.Roles", "Role")
                        .WithMany("User")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Entity.Models.Permissions", b =>
                {
                    b.Navigation("RolePemission");
                });

            modelBuilder.Entity("Entity.Models.Roles", b =>
                {
                    b.Navigation("RolePemission");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
