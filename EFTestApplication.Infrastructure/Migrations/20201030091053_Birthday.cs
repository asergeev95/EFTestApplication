using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFTestApplication.Infrastructure.Migrations
{
    public partial class Birthday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                schema: "Persons",
                table: "Person",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                schema: "Persons",
                table: "Person");
        }
    }
}
