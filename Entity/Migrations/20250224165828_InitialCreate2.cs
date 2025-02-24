using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 20, 28, 25, 643, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 20, 28, 25, 657, DateTimeKind.Local).AddTicks(4686));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 20, 18, 3, 714, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 20, 18, 3, 717, DateTimeKind.Local).AddTicks(7969));
        }
    }
}
