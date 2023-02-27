using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_3_StackOverflow.Migrations
{
    /// <inheritdoc />
    public partial class CommentedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Userid",
                table: "UserQuestionVotes");

            migrationBuilder.DropColumn(
                name: "Userid",
                table: "UserAnswerVotes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Questions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Userid",
                table: "UserQuestionVotes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Userid",
                table: "UserAnswerVotes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
