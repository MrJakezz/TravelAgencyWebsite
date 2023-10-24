using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class ContactUsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactUss",
                columns: table => new
                {
                    ContactUsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactUsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactUsMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactUsSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactUsBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactUsMessageDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUss", x => x.ContactUsID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUss");
        }
    }
}
