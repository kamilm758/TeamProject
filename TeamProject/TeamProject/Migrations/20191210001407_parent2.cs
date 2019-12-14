using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamProject.Migrations
{
    public partial class parent2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Parent",
                table: "Froms",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Parent",
                table: "Froms",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
