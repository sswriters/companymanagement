using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyManagementSystem.Migrations
{
    public partial class db6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id",
                table: "Person");

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    projectid = table.Column<string>(nullable: false),
                    projectname = table.Column<string>(nullable: true),
                    duedate = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    assigned_people = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.projectid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Person",
                nullable: false,
                defaultValue: 0);
        }
    }
}
