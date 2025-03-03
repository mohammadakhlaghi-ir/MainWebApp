using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ContextManagement
{  
    public static class ModelBuilderExtensions
    {
        // inital variables
        static string adminEmail = "michaelsevii17@gmail.com";
        static string adminPassword = "1234";
        static string adminUserName = "Admin";
        static string adminFirstName = "First Name";
        static string adminLastName = "Last Name";
        static string adminAddress = "Address";
        static string adminPhoneNumber = "09378982060";
        static string adminProfileImage = "default.png";
        static DateTime adminDefualtDate = new DateTime(1999, 1, 19);

        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Permissions
            modelBuilder.Entity<Permissions>().HasData(
                new Permissions { PermissionID = 1, PermissionName = "Create Users", Description = "Add New User To Context" },
                new Permissions { PermissionID = 2, PermissionName = "Edit Users", Description = "Edit User Details" },
                new Permissions { PermissionID = 3, PermissionName = "Delete Users", Description = "Set IsDeleted True For Users Or Delete From Context" },
                new Permissions { PermissionID = 4, PermissionName = "View Users", Description = "View Details of Users" },
                new Permissions { PermissionID = 6, PermissionName = "Create Roles", Description = "Add New Role To Context" },
                new Permissions { PermissionID = 7, PermissionName = "Edit Roles", Description = "Edit Roles Details" },
                new Permissions { PermissionID = 8, PermissionName = "Delete Roles", Description = "Set IsDeleted True For Roles Or Delete From Context" },
                new Permissions { PermissionID = 9, PermissionName = "View Roles", Description = "View Details of Roles" }
            );

            // Roles
            modelBuilder.Entity<Roles>().HasData(
                new Roles
                {
                    RoleID = 1,
                    RoleName = "Admin",
                    Description = "Administrator role",
                    IsDeleted = false,
                    CreatedDate = adminDefualtDate
                }
            );

            // Role Permissions
            modelBuilder.Entity<RolePermissions>().HasData(
                new RolePermissions { RolePermissionID = 1, RoleID = 1, PermissionID = 1 },
                new RolePermissions { RolePermissionID = 2, RoleID = 1, PermissionID = 2 },
                new RolePermissions { RolePermissionID = 3, RoleID = 1, PermissionID = 3 },
                new RolePermissions { RolePermissionID = 4, RoleID = 1, PermissionID = 4 },
                new RolePermissions { RolePermissionID = 5, RoleID = 1, PermissionID = 6 },
                new RolePermissions { RolePermissionID = 6, RoleID = 1, PermissionID = 7 },
                new RolePermissions { RolePermissionID = 7, RoleID = 1, PermissionID = 8 },
                new RolePermissions { RolePermissionID = 8, RoleID = 1, PermissionID = 9 }
            );

            // Users
            modelBuilder.Entity<Users>().HasData(
                new Users
                {
                    UserID = 1,
                    UserName =adminUserName,
                    Email = adminEmail,
                    FirstName = adminFirstName,
                    LastName = adminLastName,
                    Password = adminPassword,
                    IsDeleted = false,
                    Address = adminAddress,
                    BirthDate = adminDefualtDate,
                    PhoneNumber = adminPhoneNumber,
                    ProfileImage = adminProfileImage,
                    CreatedDate = adminDefualtDate,
                    RoleID = 1,
                    IsActived = true,
                    ModifyDate = null,
                    Modifier = null,
                }
            );
        }
    }
}
