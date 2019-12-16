using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamProject.Migrations
{
    public partial class UserAnswerListNew2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserAnswerListId",
                table: "UserAnswers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_UserAnswerListId",
                table: "UserAnswers",
                column: "UserAnswerListId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswers_UserAnswerList_UserAnswerListId",
                table: "UserAnswers",
                column: "UserAnswerListId",
                principalTable: "UserAnswerList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswers_UserAnswerList_UserAnswerListId",
                table: "UserAnswers");

            migrationBuilder.DropIndex(
                name: "IX_UserAnswers_UserAnswerListId",
                table: "UserAnswers");

            migrationBuilder.DropColumn(
                name: "UserAnswerListId",
                table: "UserAnswers");
        }
    }
}
