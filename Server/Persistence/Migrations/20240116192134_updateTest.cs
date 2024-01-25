using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class updateTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Value",
                table: "Answers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TestID",
                table: "Answers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 1,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 2,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 3,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 4,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 5,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 6,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 7,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 8,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 9,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 10,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 11,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 12,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 13,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 14,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 15,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 16,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 17,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 18,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 19,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 20,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 21,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 22,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 23,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 24,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 25,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 26,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 27,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 28,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 29,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 30,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 31,
                column: "Value",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 32,
                column: "Value",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Answers_TestID",
                table: "Answers",
                column: "TestID");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Tests_TestID",
                table: "Answers",
                column: "TestID",
                principalTable: "Tests",
                principalColumn: "TestID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Tests_TestID",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_TestID",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "TestID",
                table: "Answers");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Answers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 1,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 2,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 3,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 4,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 5,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 6,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 7,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 8,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 9,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 10,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 11,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 12,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 13,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 14,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 15,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 16,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 17,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 18,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 19,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 20,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 21,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 22,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 23,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 24,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 25,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 26,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 27,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 28,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 29,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 30,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 31,
                column: "Value",
                value: null);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 32,
                column: "Value",
                value: null);
        }
    }
}
