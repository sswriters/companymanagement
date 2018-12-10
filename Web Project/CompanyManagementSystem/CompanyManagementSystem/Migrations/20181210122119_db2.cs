using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyManagementSystem.Migrations
{
    public partial class db2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    name = table.Column<string>(nullable: false),
                    pass = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    mail = table.Column<string>(nullable: true),
                    role = table.Column<string>(nullable: true),
                    projects = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
