using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quiz_Game.Migrations
{
    /// <inheritdoc />
    public partial class QuizAnswers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuizAnswer_Quizzes_QuizId",
                table: "QuizAnswer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuizAnswer",
                table: "QuizAnswer");

            migrationBuilder.RenameTable(
                name: "QuizAnswer",
                newName: "quizAnswers");

            migrationBuilder.RenameIndex(
                name: "IX_QuizAnswer_QuizId",
                table: "quizAnswers",
                newName: "IX_quizAnswers_QuizId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_quizAnswers",
                table: "quizAnswers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_quizAnswers_Quizzes_QuizId",
                table: "quizAnswers",
                column: "QuizId",
                principalTable: "Quizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_quizAnswers_Quizzes_QuizId",
                table: "quizAnswers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_quizAnswers",
                table: "quizAnswers");

            migrationBuilder.RenameTable(
                name: "quizAnswers",
                newName: "QuizAnswer");

            migrationBuilder.RenameIndex(
                name: "IX_quizAnswers_QuizId",
                table: "QuizAnswer",
                newName: "IX_QuizAnswer_QuizId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuizAnswer",
                table: "QuizAnswer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuizAnswer_Quizzes_QuizId",
                table: "QuizAnswer",
                column: "QuizId",
                principalTable: "Quizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
