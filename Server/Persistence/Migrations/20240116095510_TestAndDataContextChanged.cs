using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class TestAndDataContextChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Tests",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                column: "Name",
                value: "Additional1");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 5, "Additional2" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 6, "Additional3" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 7, "Additional4" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 8, "Additional5" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 9, "Additional6" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 10, "Additional17" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 11, "Additional8" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 12, "Additional9" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 13, "Additional10" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 14, "Additional11" });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 17,
                column: "Number",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 18,
                column: "Number",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 19,
                column: "Number",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 20,
                column: "Number",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 21,
                column: "Number",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 22,
                column: "Number",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 23,
                column: "Number",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 24,
                column: "Number",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 25,
                column: "Number",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 26,
                column: "Number",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 27,
                column: "Number",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 28,
                column: "Number",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 29,
                column: "Number",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 30,
                column: "Number",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 31,
                column: "Number",
                value: 31);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 32,
                column: "Number",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 33,
                column: "Number",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 34,
                column: "Number",
                value: 34);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 35,
                column: "Number",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 36,
                column: "Number",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 37,
                column: "Number",
                value: 37);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 38,
                column: "Number",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 39,
                column: "Number",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 40,
                column: "Number",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 41,
                column: "Number",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 42,
                column: "Number",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 43,
                column: "Number",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 44,
                column: "Number",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 45,
                column: "Number",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 46,
                column: "Number",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 47,
                column: "Number",
                value: 47);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 48,
                column: "Number",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 49,
                column: "Number",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 50,
                column: "Number",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 51,
                column: "Number",
                value: 51);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 52,
                column: "Number",
                value: 52);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 53,
                column: "Number",
                value: 53);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 54,
                column: "Number",
                value: 54);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 55,
                column: "Number",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 56,
                column: "Number",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 57,
                column: "Number",
                value: 57);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 58,
                column: "Number",
                value: 58);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 59,
                column: "Number",
                value: 59);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 60,
                column: "Number",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 61,
                column: "Number",
                value: 61);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 62,
                column: "Number",
                value: 62);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 63,
                column: "Number",
                value: 63);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 64,
                column: "Number",
                value: 64);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 65,
                column: "Number",
                value: 65);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 66,
                column: "Number",
                value: 66);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 67,
                column: "Number",
                value: 67);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 68,
                column: "Number",
                value: 68);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 69,
                column: "Number",
                value: 69);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 70,
                column: "Number",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 71,
                column: "Number",
                value: 71);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 72,
                column: "Number",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 73,
                column: "Number",
                value: 73);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 74,
                column: "Number",
                value: 74);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 75,
                column: "Number",
                value: 75);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 76,
                column: "Number",
                value: 76);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 1,
                column: "Number",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 2,
                column: "Number",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 3,
                column: "Number",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 4,
                column: "Number",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 5,
                column: "Number",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 6,
                column: "Number",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 7,
                column: "Number",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 8,
                column: "Number",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 9,
                column: "Number",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 10,
                column: "Number",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 11,
                column: "Number",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 12,
                column: "Number",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 13,
                column: "Number",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 14,
                column: "Number",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 15,
                column: "Number",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 16,
                column: "Number",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 77,
                column: "Number",
                value: 77);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 19,
                column: "CategoryID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 20,
                column: "CategoryID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 21,
                column: "CategoryID",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 22,
                column: "CategoryID",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 23,
                column: "CategoryID",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 24,
                column: "CategoryID",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 25,
                column: "CategoryID",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 26,
                column: "CategoryID",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 27,
                column: "CategoryID",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 28,
                column: "CategoryID",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 29,
                column: "CategoryID",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 30,
                column: "CategoryID",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 31,
                column: "CategoryID",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 32,
                column: "CategoryID",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 78,
                columns: new[] { "CategoryID", "Number" },
                values: new object[] { 5, 78 });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 79,
                columns: new[] { "CategoryID", "Number" },
                values: new object[] { 6, 79 });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 80,
                columns: new[] { "CategoryID", "Number" },
                values: new object[] { 7, 80 });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 81,
                columns: new[] { "CategoryID", "Number" },
                values: new object[] { 8, 81 });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 82,
                columns: new[] { "CategoryID", "Number" },
                values: new object[] { 9, 82 });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 83,
                columns: new[] { "CategoryID", "Number" },
                values: new object[] { 10, 83 });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 84,
                columns: new[] { "CategoryID", "Number" },
                values: new object[] { 11, 84 });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 85,
                columns: new[] { "CategoryID", "Number" },
                values: new object[] { 12, 85 });

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 86,
                columns: new[] { "CategoryID", "Number" },
                values: new object[] { 13, 86 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 14);

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Tests");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 19,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 20,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 21,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 22,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 23,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 24,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 25,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 26,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 27,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 28,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 29,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 30,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 31,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 32,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                column: "Name",
                value: "Additional");

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 78,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 79,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 80,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 81,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 82,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 83,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 84,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 85,
                column: "CategoryID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 86,
                column: "CategoryID",
                value: 4);
        }
    }
}
