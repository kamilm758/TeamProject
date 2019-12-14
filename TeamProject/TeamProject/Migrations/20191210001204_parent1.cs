using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamProject.Migrations
{
    public partial class parent1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Parent",
                table: "Froms",
                nullable: true,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Parent",
                table: "Froms");
        }
    }
}
