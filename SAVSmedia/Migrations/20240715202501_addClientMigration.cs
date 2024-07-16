using Microsoft.EntityFrameworkCore.Migrations;

namespace SAVSmedia.Migrations
{
    public partial class addClientMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    companyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
