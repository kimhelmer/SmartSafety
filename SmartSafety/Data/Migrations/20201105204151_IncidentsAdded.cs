using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSafety.Data.Migrations
{
    public partial class IncidentsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteCode = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    Grid = table.Column<string>(nullable: true),
                    CameraID = table.Column<int>(nullable: false),
                    TimeStampAtSource = table.Column<string>(nullable: true),
                    TimestampAtSourceInLocalTimeZone = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    FrameID = table.Column<string>(nullable: true),
                    Payload = table.Column<string>(nullable: true),
                    TimestampAtPlatform = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incidents");
        }
    }
}
