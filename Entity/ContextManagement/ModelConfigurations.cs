using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ContextManagement
{
    public static class ModelConfigurations
    {
        public static void ConfigureRelations(ModelBuilder modelBuilder)
        {
            // 1 Role With Many Users
            modelBuilder.Entity<Users>()
                .HasOne(u => u.Role)
                .WithMany(r => r.User)
                .HasForeignKey(u => u.RoleID)
                .OnDelete(DeleteBehavior.Restrict);

            // Many-to-Many Role-Permissions Relationship
            modelBuilder.Entity<RolePermissions>()
                .HasOne(rp => rp.Role)
                .WithMany(r => r.RolePemission)
                .HasForeignKey(rp => rp.RoleID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<RolePermissions>()
                .HasOne(rp => rp.Permission)
                .WithMany(p => p.RolePemission)
                .HasForeignKey(rp => rp.PermissionID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

}
