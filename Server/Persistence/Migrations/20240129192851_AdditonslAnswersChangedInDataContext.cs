using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AdditonslAnswersChangedInDataContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 21,
                column: "Value",
                value: "assets/Avatar1.png");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 22,
                column: "Value",
                value: "assets/Avatar2.png");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 23,
                column: "Value",
                value: "assets/Avatar3.png");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 24,
                column: "Value",
                value: "assets/Avatar4.png");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 25,
                column: "Value",
                value: "assets/Sad.png");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 26,
                column: "Value",
                value: "assets/Happy.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 21,
                column: "Value",
                value: "");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 22,
                column: "Value",
                value: "");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 23,
                column: "Value",
                value: "");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 24,
                column: "Value",
                value: "");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 25,
                column: "Value",
                value: "");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 26,
                column: "Value",
                value: "");
        }
    }
}
