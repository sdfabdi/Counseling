using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    AnswerID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Score = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.AnswerID);
                    table.ForeignKey(
                        name: "FK_Answers_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    TestID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Question = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    PersonalType = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.TestID);
                    table.ForeignKey(
                        name: "FK_Tests_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 1, "MBTI" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 2, "PHQ-9" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 3, "GAD-7" });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 17, 1, "MBTI", "EI", "You regularly make new friends." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 18, 1, "MBTI", "JP", "You spend a lot of your free time exploring various random topics that pique your interest." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 19, 1, "MBTI", "TF", "Seeing other people cry can easily make you feel like you want to cry too." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 20, 1, "MBTI", "JP", "You often make a backup plan for a backup plan." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 21, 1, "MBTI", "TF", "You usually stay calm, even under a lot of pressure." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 22, 1, "MBTI", "EI", "At social events, you rarely try to introduce yourself to new people and mostly talk to the ones you already know." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 23, 1, "MBTI", "JP", "You prefer to completely finish one project before starting another." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 24, 1, "MBTI", "TF", "You are very sentimental." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 25, 1, "MBTI", "JP", "You like to use organizing tools like schedules and lists." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 26, 1, "MBTI", "?", "Even a small mistake can cause you to doubt your overall abilities and knowledge." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 27, 1, "MBTI", "EI", "You feel comfortable jist walking up to someone you find interesting and striking up a conversation." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 28, 1, "MBTI", "SN", "You are not too interested in discussing various interpretations and analyses of creative works." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 29, 1, "MBTI", "TF", "You are more inclined to follow your head than your heart." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 30, 1, "MBTI", "JP", "You usually prefer just doing what you feel like at any given moment instead of planning a particular daily routine." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 31, 1, "MBTI", "EI", "You rarely worry about whether you make a good impression on people you meet." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 32, 1, "MBTI", "EI", "You enjoy participating in group activities." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 33, 1, "MBTI", "JP", "You like books and movies that make you come up with your own interpretation of the ending." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 34, 1, "MBTI", "TF", "Your happiness comes more from helping others accomplish things than your own accomplishments." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 35, 1, "MBTI", "JP", "You are interested in so many things that you find it difficult to choose what to try next." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 36, 1, "MBTI", "JP", "You are prone to worrying that things will take a turn for the worse." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 37, 1, "MBTI", "EI", "You avoid leadership roles in group settings." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 38, 1, "MBTI", "TF", "You are definitely not an artistic type of person." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 39, 1, "MBTI", "TF", "You think the world would be a better place if people relied more on rationality and less on their feelings." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 40, 1, "MBTI", "JP", "You prefer to do your chores before allowing yourself to relax." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 41, 1, "MBTI", "?", "You enjoy watching people argue." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 42, 1, "MBTI", "EI", "You tend to avoid drawing attention to yourself." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 43, 1, "MBTI", "TF", "Your mood can change very quickly." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 44, 1, "MBTI", "JP", "You lose patience with people who are not as efficient as you." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 45, 1, "MBTI", "JP", "You often end up doing things at the last possible moment." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 46, 1, "MBTI", "SN", "You have always been fascinated by the question of what, if anything, happens after death." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 47, 1, "MBTI", "EI", "You usually prefer to be around others rather than on your own." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 48, 1, "MBTI", "SN", "You become bored or lose interest when the discussion gets highly theoretical." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 49, 1, "MBTI", "TF", "You find it easy to empathize with a person whose experiences are very different from yours." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 50, 1, "MBTI", "JP", "You usually postpone finalizing decisions for as long as possible." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 51, 1, "MBTI", "JP", "You rarely second-guess the choices that you have made." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 52, 1, "MBTI", "EI", "After a long and exhausting week, a lively social event is just what you need." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 53, 1, "MBTI", "?", "You enjoy going to art museums." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 54, 1, "MBTI", "TF", "You often have a hard time understanding other people’s feelings." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 55, 1, "MBTI", "JP", "You like to have a to-do list for each day." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 56, 1, "MBTI", "TF", "You rarely feel insecure." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 57, 1, "MBTI", "EI", "You avoid making phone calls." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 58, 1, "MBTI", "?", "You often spend a lot of time trying to understand views that are very different from your own." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 59, 1, "MBTI", "EI", "In your social circle, you are often the one who contacts your friends and initiates activities." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 60, 1, "MBTI", "JP", "If your plans are interrupted, your top priority is to get back on track as soon as possible." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 61, 1, "MBTI", "JP", "You are still bothered by mistakes that you made a long time ago." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 62, 1, "MBTI", "SN", "You rarely contemplate the reasons for human existence or the meaning of life." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 63, 1, "MBTI", "TF", "Your emotions control you more than you control them." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 64, 1, "MBTI", "TF", "You take great care not to make people look bad, even when it is completely their fault." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 65, 1, "MBTI", "JP", "Your personal work style is closer to spontaneous bursts of energy than organized and consistent efforts." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 66, 1, "MBTI", "?", "When someone thinks highly of you, you wonder how long it will take them to feel disappointed in you." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 67, 1, "MBTI", "EI", "You would love a job that requires you to work alone most of the time." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 68, 1, "MBTI", "SN", "You believe that pondering abstract philosophical Question is a waste of time." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 69, 1, "MBTI", "EI", "You feel more drawn to places with busy, bustling atmospheres than quiet, intimate places." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 70, 1, "MBTI", "TF", "You know at first glance how someone is feeling." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 71, 1, "MBTI", "?", "You often feel overwhelmed." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 72, 1, "MBTI", "JP", "You complete things methodically without skipping over any steps." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 73, 1, "MBTI", "?", "You are very intrigued by things labeled as controversial." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 74, 1, "MBTI", "TF", "You would pass along a good opportunity if you thought someone else needed it more." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 75, 1, "MBTI", "JP", "You struggle with deadlines." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "PersonalType", "Question" },
                values: new object[] { 76, 1, "MBTI", "?", "You feel confident that things will work out for you." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 1, 2, "Test", "1. Little interest or pleasure in doing things." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 2, 2, "Test", "2. Feeling down, depressed, or hopeless." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 3, 2, "Test", "3. Trouble falling or staying asleep, or sleeping too much." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 4, 2, "Test", "4. Feeling tired or having little energy." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 5, 2, "Test", "5. Poor appetite or overeating." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 6, 2, "Test", "6. Feeling bad about yourself or that you are a failure or have let yourself or your family down." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 7, 2, "Test", "7. Trouble concentrating on things, such as reading the newspaper or watching television." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 8, 2, "Test", "8. Moving or speaking so slowly that other people could have noticed. Or the opposite being so fidgety or restless that you have been moving around a lot more than usual." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 9, 2, "Test", "9. Thoughts that you would be better off dead, or of hurting yourself in some way." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 10, 3, "Test", "1. Feeling nervous, anxious, or on edge." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 11, 3, "Test", "2. Not being able to stop or control worrying." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 12, 3, "Test", "3. Worrying too much about different things." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 13, 3, "Test", "4. Trouble relaxing." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 14, 3, "Test", "5. Being so restless that it’s hard to sit still." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 15, 3, "Test", "6. Becoming easily annoyed or irritable." });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "TestID", "CategoryID", "Discriminator", "Question" },
                values: new object[] { 16, 3, "Test", "7. Feeling afraid as if something awful might happen." });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_CategoryID",
                table: "Answers",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_CategoryID",
                table: "Tests",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
