using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts1",
                columns: table => new
                {
                    About1ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    About1Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About1Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About1Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About1Title2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About1Description2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About1Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts1", x => x.About1ID);
                });

            migrationBuilder.CreateTable(
                name: "Abouts2",
                columns: table => new
                {
                    About2ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    About2Title1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About2Title2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About2Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About2Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts2", x => x.About2ID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    DestinationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinationCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationDayNight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationPrice = table.Column<double>(type: "float", nullable: false),
                    DestinationImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationStatus = table.Column<bool>(type: "bit", nullable: false),
                    DestinationCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationID);
                });

            migrationBuilder.CreateTable(
                name: "Features1",
                columns: table => new
                {
                    Feature1ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Feature1Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature1Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature1Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature1Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features1", x => x.Feature1ID);
                });

            migrationBuilder.CreateTable(
                name: "Features2",
                columns: table => new
                {
                    Feature2ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Feature2Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature2Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature2Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature2Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features2", x => x.Feature2ID);
                });

            migrationBuilder.CreateTable(
                name: "Guides",
                columns: table => new
                {
                    GuideID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuideName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideTwitterURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideInstagramURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guides", x => x.GuideID);
                });

            migrationBuilder.CreateTable(
                name: "Newsletters",
                columns: table => new
                {
                    NewsletterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsletterMail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletters", x => x.NewsletterID);
                });

            migrationBuilder.CreateTable(
                name: "SubAbouts",
                columns: table => new
                {
                    SubAboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubAboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubAboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAbouts", x => x.SubAboutID);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    TestimonialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestimonialClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestimonialComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestimonialClientImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestimonialStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.TestimonialID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts1");

            migrationBuilder.DropTable(
                name: "Abouts2");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropTable(
                name: "Features1");

            migrationBuilder.DropTable(
                name: "Features2");

            migrationBuilder.DropTable(
                name: "Guides");

            migrationBuilder.DropTable(
                name: "Newsletters");

            migrationBuilder.DropTable(
                name: "SubAbouts");

            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
