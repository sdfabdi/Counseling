using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AnswersAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "Score", "Title" },
                values: new object[] { 1, 1, 3, "Strongly Agree" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "Score", "Title" },
                values: new object[] { 2, 1, 2, "Agree" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "Score", "Title" },
                values: new object[] { 3, 1, 1, "Slightly Agree" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "Score", "Title" },
                values: new object[] { 4, 1, 0, "Neutral" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "Score", "Title" },
                values: new object[] { 5, 1, -1, "Slightly Disagree" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "Score", "Title" },
                values: new object[] { 6, 1, -2, "Disagree" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "Score", "Title" },
                values: new object[] { 7, 1, -3, "Strongly Disagree" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "Score", "Title" },
                values: new object[] { 8, 2, 0, "Not at all" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "Score", "Title" },
                values: new object[] { 9, 2, 1, "Several days" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "Score", "Title" },
                values: new object[] { 10, 2, 2, "More than half the days" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "Score", "Title" },
                values: new object[] { 11, 2, 3, "Nearly every day" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "Score", "Title" },
                values: new object[] { 12, 3, 0, "Not at all sure" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "Score", "Title" },
                values: new object[] { 13, 3, 1, "Several days" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "Score", "Title" },
                values: new object[] { 14, 3, 2, "Over half the days" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "Score", "Title" },
                values: new object[] { 15, 3, 3, "Nearly every day" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 15);
        }
    }
}
