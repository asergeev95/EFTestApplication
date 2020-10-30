using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFTestApplication.Infrastructure.Migrations
{
    public partial class Relatives : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Relative",
                schema: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Relation = table.Column<string>(nullable: false),
                    PersonId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relative", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Relative_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Persons",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Relative_PersonId",
                schema: "Persons",
                table: "Relative",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Relative",
                schema: "Persons");
        }
    }
}
