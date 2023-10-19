using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_destination_details : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "About1Title",
                table: "Abouts1",
                newName: "About1Title1");

            migrationBuilder.RenameColumn(
                name: "About1Image1",
                table: "Abouts1",
                newName: "About1Image");

            migrationBuilder.AddColumn<string>(
                name: "DestinationCoverImage",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DestinationDetails1",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DestinationDetails2",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DestinationImageBlog",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DestinationCoverImage",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DestinationDetails1",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DestinationDetails2",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DestinationImageBlog",
                table: "Destinations");

            migrationBuilder.RenameColumn(
                name: "About1Title1",
                table: "Abouts1",
                newName: "About1Title");

            migrationBuilder.RenameColumn(
                name: "About1Image",
                table: "Abouts1",
                newName: "About1Image1");
        }
    }
}
