using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AnswerAndDataContestChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPhoto",
                table: "Answers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "Answers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 4, "Additional" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "IsPhoto", "Score", "Title", "Value" },
                values: new object[] { 16, 4, true, 1, "Light Blue or Green", null });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "IsPhoto", "Score", "Title", "Value" },
                values: new object[] { 17, 4, true, 2, "Dark Blue or Yellow", null });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "IsPhoto", "Score", "Title", "Value" },
                values: new object[] { 18, 4, true, 3, "Red or Orange", null });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "IsPhoto", "Score", "Title", "Value" },
                values: new object[] { 19, 4, true, 1, "Day", null });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "IsPhoto", "Score", "Title", "Value" },
                values: new object[] { 20, 4, true, 2, "Night", null });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "IsPhoto", "Score", "Title", "Value" },
                values: new object[] { 21, 4, true, 1, "First Avatar", null });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "IsPhoto", "Score", "Title", "Value" },
                values: new object[] { 22, 4, true, 2, "Second Avatar", null });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "IsPhoto", "Score", "Title", "Value" },
                values: new object[] { 23, 4, true, 3, "Third Avatar", null });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "IsPhoto", "Score", "Title", "Value" },
                values: new object[] { 24, 4, true, 4, "Fourth Avatar", null });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "IsPhoto", "Score", "Title", "Value" },
                values: new object[] { 25, 4, false, 0, "Sad Image", null });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "IsPhoto", "Score", "Title", "Value" },
                values: new object[] { 26, 4, false, 0, "Joyful Image", null });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "IsPhoto", "Score", "Title", "Value" },
                values: new object[] { 27, 4, false, 0, "Next 5 years", null });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "IsPhoto", "Score", "Title", "Value" },
                values: new object[] { 28, 4, false, 0, "Next 10 years", null });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "IsPhoto", "Score", "Title", "Value" },
                values: new object[] { 29, 4, false, 0, "Past 10 years", null });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "IsPhoto", "Score", "Title", "Value" },
                values: new object[] { 30, 4, false, 0, "Today", null });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "IsPhoto", "Score", "Title", "Value" },
                values: new object[] { 31, 4, false, 0, "Engaging", null });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "CategoryID", "IsPhoto", "Score", "Title", "Value" },
                values: new object[] { 32, 4, false, 0, "Share with us", null });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 77, 4, "Test", "Among these images, which one appeals to you the most?" });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 78, 4, "Test", "Which one do you prefer?" });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 79, 4, "Test", "Which of the following images would you like to choose as your profile picture?" });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 80, 4, "Test", "Please describe the following image briefly." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 81, 4, "Test", "How do you envision yourself in 5 years from now?" });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 82, 4, "Test", "How do you envision yourself in 10 years from now?" });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 83, 4, "Test", "How would you describe the past 10 years of yourself?" });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 84, 4, "Test", "How would you describe your day so far?" });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 85, 4, "Test", "Would you be interested in engaging with our website to boost your spirits?" });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 86, 4, "Test", "Do you have any additional comments or thoughts you'd like to share with us?" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "TestID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "IsPhoto",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Answers");
        }
    }
}
