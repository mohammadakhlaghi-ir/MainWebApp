using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity
{
    public class MainDbContext(DbContextOptions<MainDbContext> options) : DbContext(options)
    {
        #region Models
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<RolePermissions> RolePermissions { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Relations
            // 1 Role With Many Users
            modelBuilder.Entity<Users>()
                .HasOne(u => u.Role)
                .WithMany(r => r.User)
                .HasForeignKey(u => u.RoleID)
                .OnDelete(DeleteBehavior.Restrict);

            // Many Roles With Many Permissions 
            modelBuilder.Entity<RolePermissions>()
                .HasOne(rp => rp.Role)
                .WithMany(r => r.RolePermission)
                .HasForeignKey(rp => rp.RoleID)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<RolePermissions>()
                .HasOne(rp => rp.Permission)
                .WithMany(p => p.RolePermission)
                .HasForeignKey(rp => rp.PermissionID)
                .OnDelete(DeleteBehavior.Cascade);

            #endregion

            #region Inserted Rows
            // Permission Rows
            modelBuilder.Entity<Permissions>().HasData(
               new Permissions
               {
                   PermissionID = 1,
                   PermissionName = "Create Users",
                   Description = "Add New User To Context",
               },
               new Permissions
               {
                   PermissionID = 2,
                   PermissionName = "Edit Users",
                   Description = "Edit User Details",
               },
               new Permissions
               {
                   PermissionID = 3,
                   PermissionName = "Delete Users",
                   Description = "Set IsDeleted True For Users Or Delete From Context",
               },
               new Permissions
               {
                   PermissionID = 4,
                   PermissionName = "View Users",
                   Description = "View Details of Users",
               },
               new Permissions
               {
                   PermissionID = 6,
                   PermissionName = "Create Roles",
                   Description = "Add New Role To Context",
               },
               new Permissions
               {
                   PermissionID = 7,
                   PermissionName = "Edit Roles",
                   Description = "Edit Roles Details",
               },
               new Permissions
               {
                   PermissionID = 8,
                   PermissionName = "Delete Roles",
                   Description = "Set IsDeleted True For Roles Or Delete From Context",
               },
               new Permissions
               {
                   PermissionID = 9,
                   PermissionName = "View Roles",
                   Description = "View Details of Roles",
               }
           );

            //Roles Rows
            modelBuilder.Entity<Roles>().HasData(
                new Roles
                {
                    RoleID = 1,
                    RoleName = "Admin",
                    Description = "Administrator role",
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                }
            );

            //RolePermssions Rows
            modelBuilder.Entity<RolePermissions>().HasData(
                 new RolePermissions { RolePermissionID = 1, RoleID = 1, PermissionID = 1, },
                 new RolePermissions { RolePermissionID = 2, RoleID = 1, PermissionID = 2, },
                 new RolePermissions { RolePermissionID = 3, RoleID = 1, PermissionID = 3, },
                 new RolePermissions { RolePermissionID = 4, RoleID = 1, PermissionID = 4, },
                 new RolePermissions { RolePermissionID = 5, RoleID = 1, PermissionID = 6, },
                 new RolePermissions { RolePermissionID = 6, RoleID = 1, PermissionID = 7, },
                 new RolePermissions { RolePermissionID = 7, RoleID = 1, PermissionID = 8, },
                 new RolePermissions { RolePermissionID = 8, RoleID = 1, PermissionID = 9, }
             );

            //Users Rows
            modelBuilder.Entity<Users>().HasData(
                new Users
                {
                    UserID = 1,
                    UserName = "Admin",
                    Email = "michaelsevii17@gmail.com",
                    FirstName = "First Name",
                    LastName = "Last Name",
                    Password = "123456",
                    IsDeleted = false,
                    Address = "Address",
                    BirthDate = new DateTime(1990, 1, 1),
                    PhoneNumber = "123456789",
                    ProfileImage = "/images/profileImages/Admin.jpg",
                    CreatedDate = DateTime.Now,
                    RoleID = 1,
                    IsActived = true,
                }
            );
        }
        #endregion
    }
}
