using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence;

public class DataContext: DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Test> Tests { get; set; }
    public virtual DbSet<Answer> Answers { get; set; }
    public virtual DbSet<MBTI> MBTIs { get; set; }
    public virtual DbSet<UserAnswer> UserAnswers { get; set; }
    public virtual DbSet<User> Users { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure relationships
            
        modelBuilder.Entity<Test>()
            .HasOne(t => t.Category)
            .WithMany(c => c.Tests)
            .HasForeignKey(t => t.CategoryID);

        modelBuilder.Entity<Answer>()
            .HasOne(a => a.Category)
            .WithMany(c => c.Answers)
            .HasForeignKey(a => a.CategoryID);

        modelBuilder.Entity<MBTI>().HasBaseType<Test>();



        // Seed Data

        //Category
        modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryID = 1,
                    Name = "MBTI"
                },
                new Category
                {
                    CategoryID = 2,
                    Name = "PHQ-9"
                },
                new Category
                {
                    CategoryID = 3,
                    Name = "GAD-7"
                },
                new Category
                {
                    CategoryID = 4,
                    Name = "Additional1"
                },
                new Category
                {
                    CategoryID = 5,
                    Name = "Additional2"
                },
                new Category
                {
                    CategoryID = 6,
                    Name = "Additional3"
                },
                new Category
                {
                    CategoryID = 7,
                    Name = "Additional4"
                },
                new Category
                {
                    CategoryID = 8,
                    Name = "Additional5"
                },
                new Category
                {
                    CategoryID = 9,
                    Name = "Additional6"
                },
                new Category
                {
                    CategoryID = 10,
                    Name = "Additional17"
                },
                new Category
                {
                    CategoryID = 11,
                    Name = "Additional8"
                },
                new Category
                {
                    CategoryID = 12,
                    Name = "Additional9"
                },
                new Category
                {
                    CategoryID = 13,
                    Name = "Additional10"
                },
                new Category
                {
                    CategoryID = 14,
                    Name = "Additional11"
                }
            );

        // Test
        modelBuilder.Entity<Test>().HasData(
                new Test
                {
                    TestID = 1,
                    CategoryID = 2,
                    Question = "1. Little interest or pleasure in doing things.",
                    Number = 1,
                },
                new Test
                {
                    TestID = 2,
                    CategoryID = 2,
                    Question = "2. Feeling down, depressed, or hopeless.",
                    Number = 2,
                },
                new Test
                {
                    TestID = 3,
                    CategoryID = 2,
                    Question = "3. Trouble falling or staying asleep, or sleeping too much.",
                    Number = 3,
                },
                new Test
                {
                    TestID = 4,
                    CategoryID = 2,
                    Question = "4. Feeling tired or having little energy.",
                    Number = 4,
                },
                new Test
                {
                    TestID = 5,
                    CategoryID = 2,
                    Question = "5. Poor appetite or overeating.",
                    Number = 5,
                },
                new Test
                {
                    TestID = 6,
                    CategoryID = 2,
                    Question = "6. Feeling bad about yourself or that you are a failure or have let yourself or your family down.",
                    Number = 6,
                },
                new Test
                {
                    TestID = 7,
                    CategoryID = 2,
                    Question = "7. Trouble concentrating on things, such as reading the newspaper or watching television.",
                    Number = 7,
                },
                new Test
                {
                    TestID = 8,
                    CategoryID = 2,
                    Question = "8. Moving or speaking so slowly that other people could have noticed. Or the opposite being so fidgety or restless that you have been moving around a lot more than usual.",
                    Number = 8,
                },
                new Test
                {
                    TestID = 9,
                    CategoryID = 2,
                    Question = "9. Thoughts that you would be better off dead, or of hurting yourself in some way.",
                    Number = 9,
                },

                //Seed Question for GAD-7

                new Test
                {
                    TestID = 10,
                    CategoryID = 3,
                    Question = "1. Feeling nervous, anxious, or on edge.",
                    Number = 1,
                },
                new Test
                {
                    TestID = 11,
                    CategoryID = 3,
                    Question = "2. Not being able to stop or control worrying.",
                    Number = 2,
                },
                new Test
                {
                    TestID = 12,
                    CategoryID = 3,
                    Question = "3. Worrying too much about different things.",
                    Number = 3,
                },
                new Test
                {
                    TestID = 13,
                    CategoryID = 3,
                    Question = "4. Trouble relaxing.",
                    Number = 4,
                },
                new Test
                {
                    TestID = 14,
                    CategoryID = 3,
                    Question = "5. Being so restless that it’s hard to sit still.",
                    Number = 5,
                },
                new Test
                {
                    TestID = 15,
                    CategoryID = 3,
                    Question = "6. Becoming easily annoyed or irritable.",
                    Number = 6,
                },
                new Test
                {
                    TestID = 16,
                    CategoryID = 3,
                    Question = "7. Feeling afraid as if something awful might happen.",
                    Number = 7,
                },

                //Additional questions for data set

                new Test
                {
                    TestID = 77,
                    CategoryID = 4,
                    Question = "Among these images, which one appeals to you the most?",
                    Number = 1,
                },
                new Test
                {
                    TestID = 78,
                    CategoryID = 5,
                    Question = "Which one do you prefer?",
                    Number = 2,
                },
                new Test
                {
                    TestID = 79,
                    CategoryID = 6,
                    Question = "Which of the following images would you like to choose as your profile picture?",
                    Number = 3,
                },
                new Test
                {
                    TestID = 80,
                    CategoryID = 7,
                    Question = "Please describe the following image briefly.",
                    Number = 4,
                },
                new Test
                {
                    TestID = 81,
                    CategoryID = 8,
                    Question = "Please describe the following image briefly.",
                    Number = 5,
                },
                new Test
                {
                    TestID = 82,
                    CategoryID = 9,
                    Question = "How do you envision yourself in 5 years from now?",
                    Number = 6,
                },
                new Test
                {
                    TestID = 83,
                    CategoryID = 10,
                    Question = "How do you envision yourself in 10 years from now?",
                    Number = 7,
                },
                new Test
                {
                    TestID = 84,
                    CategoryID = 11,
                    Question = "How would you describe the past 10 years of yourself?",
                    Number = 8,
                },
                new Test
                {
                    TestID = 85,
                    CategoryID = 12,
                    Question = "How would you describe your day so far?",
                    Number = 9,
                },
                new Test
                {
                    TestID = 86,
                    CategoryID = 13,
                    Question = "Would you be interested in engaging with our website to boost your spirits?",
                    Number = 10,
                },
                new Test
                {
                    TestID = 87,
                    CategoryID = 14,
                    Question = "Do you have any additional comments or thoughts you'd like to share with us?",
                    Number = 11,
                }
            );
        // MBTI
        modelBuilder.Entity<MBTI>().HasData(
                new MBTI
                {
                    TestID = 17,
                    CategoryID = 1,
                    Question = "You regularly make new friends.",
                    Number = 1,
                    PersonalType = "EI"
                },
                new MBTI
                {
                    TestID = 18,
                    CategoryID = 1,
                    Question = "You spend a lot of your free time exploring various random topics that pique your interest.",
                    Number = 2,
                    PersonalType = "JP"
                },
                new MBTI
                {
                    TestID = 19,
                    CategoryID = 1,
                    Question = "Seeing other people cry can easily make you feel like you want to cry too.",
                    Number = 3,
                    PersonalType = "TF"
                },
                new MBTI
                {
                    TestID = 20,
                    CategoryID = 1,
                    Question = "You often make a backup plan for a backup plan.",
                    Number = 4,
                    PersonalType = "JP"
                },
                new MBTI
                {
                    TestID = 21,
                    CategoryID = 1,
                    Question = "You usually stay calm, even under a lot of pressure.",
                    Number = 5,
                    PersonalType = "TF"
                },
                new MBTI
                {
                    TestID = 22,
                    CategoryID = 1,
                    Question = "At social events, you rarely try to introduce yourself to new people and mostly talk to the ones you already know.",
                    Number = 6,
                    PersonalType = "EI"
                },
                new MBTI
                {
                    TestID = 23,
                    CategoryID = 1,
                    Question = "You prefer to completely finish one project before starting another.",
                    Number = 7,
                    PersonalType = "JP"
                },
                new MBTI
                {
                    TestID = 24,
                    CategoryID = 1,
                    Question = "You are very sentimental.",
                    Number = 8,
                    PersonalType = "TF"
                },
                new MBTI
                {
                    TestID = 25,
                    CategoryID = 1,
                    Question = "You like to use organizing tools like schedules and lists.",
                    Number = 9,
                    PersonalType = "JP"
                },
                new MBTI
                {
                    TestID = 26,
                    CategoryID = 1,
                    Question = "Even a small mistake can cause you to doubt your overall abilities and knowledge.",
                    Number = 10,
                    PersonalType = "?"
                },
                new MBTI
                {
                    TestID = 27,
                    CategoryID = 1,
                    Question = "You feel comfortable jist walking up to someone you find interesting and striking up a conversation.",
                    Number = 11,
                    PersonalType = "EI"
                },
                new MBTI
                {
                    TestID = 28,
                    CategoryID = 1,
                    Question = "You are not too interested in discussing various interpretations and analyses of creative works.",
                    Number = 12,
                    PersonalType = "SN"
                },
                new MBTI
                {
                    TestID = 29,
                    CategoryID = 1,
                    Question = "You are more inclined to follow your head than your heart.",
                    Number = 13,
                    PersonalType = "TF"
                },
                new MBTI
                {
                    TestID = 30,
                    CategoryID = 1,
                    Question = "You usually prefer just doing what you feel like at any given moment instead of planning a particular daily routine.",
                    Number = 14,
                    PersonalType = "JP"
                },
                new MBTI
                {
                    TestID = 31,
                    CategoryID = 1,
                    Question = "You rarely worry about whether you make a good impression on people you meet.",
                    Number = 15,
                    PersonalType = "EI"
                },
                new MBTI
                {
                    TestID = 32,
                    CategoryID = 1,
                    Question = "You enjoy participating in group activities.",
                    Number = 16,
                    PersonalType = "EI"
                },
                new MBTI
                {
                    TestID = 33,
                    CategoryID = 1,
                    Question = "You like books and movies that make you come up with your own interpretation of the ending.",
                    Number = 17,
                    PersonalType = "JP"
                },
                new MBTI
                {
                    TestID = 34,
                    CategoryID = 1,
                    Question = "Your happiness comes more from helping others accomplish things than your own accomplishments.",
                    Number = 18,
                    PersonalType = "TF"
                },
                new MBTI
                {
                    TestID = 35,
                    CategoryID = 1,
                    Question = "You are interested in so many things that you find it difficult to choose what to try next.",
                    Number = 19,
                    PersonalType = "JP"
                },
                new MBTI
                {
                    TestID = 36,
                    CategoryID = 1,
                    Question = "You are prone to worrying that things will take a turn for the worse.",
                    Number = 20,
                    PersonalType = "JP"
                },
                new MBTI
                {
                    TestID = 37,
                    CategoryID = 1,
                    Question = "You avoid leadership roles in group settings.",
                    Number = 21,
                    PersonalType = "EI"
                },
                new MBTI
                {
                    TestID = 38,
                    CategoryID = 1,
                    Question = "You are definitely not an artistic type of person.",
                    Number = 22,
                    PersonalType = "TF"
                },
                new MBTI
                {
                    TestID = 39,
                    CategoryID = 1,
                    Question = "You think the world would be a better place if people relied more on rationality and less on their feelings.",
                    Number = 23,
                    PersonalType = "TF"
                },
                new MBTI
                {
                    TestID = 40,
                    CategoryID = 1,
                    Question = "You prefer to do your chores before allowing yourself to relax.",
                    Number = 24,
                    PersonalType = "JP"
                },
                new MBTI
                {
                    TestID = 41,
                    CategoryID = 1,
                    Question = "You enjoy watching people argue.",
                    Number = 25,
                    PersonalType = "?"
                },
                new MBTI
                {
                    TestID = 42,
                    CategoryID = 1,
                    Question = "You tend to avoid drawing attention to yourself.",
                    Number = 26,
                    PersonalType = "EI"
                },
                new MBTI
                {
                    TestID = 43,
                    CategoryID = 1,
                    Question = "Your mood can change very quickly.",
                    Number = 27,
                    PersonalType = "TF"
                },
                new MBTI
                {
                    TestID = 44,
                    CategoryID = 1,
                    Question = "You lose patience with people who are not as efficient as you.",
                    Number = 28,
                    PersonalType = "JP"
                },
                new MBTI
                {
                    TestID = 45,
                    CategoryID = 1,
                    Question = "You often end up doing things at the last possible moment.",
                    Number = 29,
                    PersonalType = "JP"
                },
                new MBTI
                {
                    TestID = 46,
                    CategoryID = 1,
                    Question = "You have always been fascinated by the question of what, if anything, happens after death.",
                    Number = 30,
                    PersonalType = "SN"
                },
                new MBTI
                {
                    TestID = 47,
                    CategoryID = 1,
                    Question = "You usually prefer to be around others rather than on your own.",
                    Number = 31,
                    PersonalType = "EI"
                },
                new MBTI
                {
                    TestID = 48,
                    CategoryID = 1,
                    Question = "You become bored or lose interest when the discussion gets highly theoretical.",
                    Number = 32,
                    PersonalType = "SN"
                },
                new MBTI
                {
                    TestID = 49,
                    CategoryID = 1,
                    Question = "You find it easy to empathize with a person whose experiences are very different from yours.",
                    Number = 33,
                    PersonalType = "TF"
                },
                new MBTI
                {
                    TestID = 50,
                    CategoryID = 1,
                    Question = "You usually postpone finalizing decisions for as long as possible.",
                    Number = 34,
                    PersonalType = "JP"
                },
                new MBTI
                {
                    TestID = 51,
                    CategoryID = 1,
                    Question = "You rarely second-guess the choices that you have made.",
                    Number = 35,
                    PersonalType = "JP"
                },
                new MBTI
                {
                    TestID = 52,
                    CategoryID = 1,
                    Question = "After a long and exhausting week, a lively social event is just what you need.",
                    Number = 36,
                    PersonalType = "EI"
                },
                new MBTI
                {
                    TestID = 53,
                    CategoryID = 1,
                    Question = "You enjoy going to art museums.",
                    Number = 37,
                    PersonalType = "?"
                },
                new MBTI
                {
                    TestID = 54,
                    CategoryID = 1,
                    Question = "You often have a hard time understanding other people’s feelings.",
                    Number = 38,
                    PersonalType = "TF"
                },
                new MBTI
                {
                    TestID = 55,
                    CategoryID = 1,
                    Question = "You like to have a to-do list for each day.",
                    Number = 39,
                    PersonalType = "JP"
                },
                new MBTI
                {
                    TestID = 56,
                    CategoryID = 1,
                    Question = "You rarely feel insecure.",
                    Number = 40,
                    PersonalType = "TF"
                },
                new MBTI
                {
                    TestID = 57,
                    CategoryID = 1,
                    Question = "You avoid making phone calls.",
                    Number = 41,
                    PersonalType = "EI"
                },
                new MBTI
                {
                    TestID = 58,
                    CategoryID = 1,
                    Question = "You often spend a lot of time trying to understand views that are very different from your own.",
                    Number = 42,
                    PersonalType = "?"
                },
                new MBTI
                {
                    TestID = 59,
                    CategoryID = 1,
                    Question = "In your social circle, you are often the one who contacts your friends and initiates activities.",
                    Number = 43,
                    PersonalType = "EI"
                },
                new MBTI
                {
                    TestID = 60,
                    CategoryID = 1,
                    Question = "If your plans are interrupted, your top priority is to get back on track as soon as possible.",
                    Number = 44,
                    PersonalType = "JP"
                },
                new MBTI
                {
                    TestID = 61,
                    CategoryID = 1,
                    Question = "You are still bothered by mistakes that you made a long time ago.",
                    Number = 45,
                    PersonalType = "JP"
                },
                new MBTI
                {
                    TestID = 62,
                    CategoryID = 1,
                    Question = "You rarely contemplate the reasons for human existence or the meaning of life.",
                    Number = 46,
                    PersonalType = "SN"
                },
                new MBTI
                {
                    TestID = 63,
                    CategoryID = 1,
                    Question = "Your emotions control you more than you control them.",
                    Number = 47,
                    PersonalType = "TF"
                },
                new MBTI
                {
                    TestID = 64,
                    CategoryID = 1,
                    Question = "You take great care not to make people look bad, even when it is completely their fault.",
                    Number = 48,
                    PersonalType = "TF"
                },
                new MBTI
                {
                    TestID = 65,
                    CategoryID = 1,
                    Question = "Your personal work style is closer to spontaneous bursts of energy than organized and consistent efforts.",
                    Number = 49,
                    PersonalType = "JP"
                },
                new MBTI
                {
                    TestID = 66,
                    CategoryID = 1,
                    Question = "When someone thinks highly of you, you wonder how long it will take them to feel disappointed in you.",
                    Number = 50,
                    PersonalType = "?"
                },
                new MBTI
                {
                    TestID = 67,
                    CategoryID = 1,
                    Question = "You would love a job that requires you to work alone most of the time.",
                    Number = 51,
                    PersonalType = "EI"
                },
                new MBTI
                {
                    TestID = 68,
                    CategoryID = 1,
                    Question = "You believe that pondering abstract philosophical Question is a waste of time.",
                    Number = 52,
                    PersonalType = "SN"
                },
                new MBTI
                {
                    TestID = 69,
                    CategoryID = 1,
                    Question = "You feel more drawn to places with busy, bustling atmospheres than quiet, intimate places.",
                    Number = 53,
                    PersonalType = "EI"
                },
                new MBTI
                {
                    TestID = 70,
                    CategoryID = 1,
                    Question = "You know at first glance how someone is feeling.",
                    Number = 54,
                    PersonalType = "TF"
                },
                new MBTI
                {
                    TestID = 71,
                    CategoryID = 1,
                    Question = "You often feel overwhelmed.",
                    Number = 55,
                    PersonalType = "?"
                },
                new MBTI
                {
                    TestID = 72,
                    CategoryID = 1,
                    Question = "You complete things methodically without skipping over any steps.",
                    Number = 56,
                    PersonalType = "JP"
                },
                new MBTI
                {
                    TestID = 73,
                    CategoryID = 1,
                    Question = "You are very intrigued by things labeled as controversial.",
                    Number = 57,
                    PersonalType = "?"
                },
                new MBTI
                {
                    TestID = 74,
                    CategoryID = 1,
                    Question = "You would pass along a good opportunity if you thought someone else needed it more.",
                    Number = 58,
                    PersonalType = "TF"
                },
                new MBTI
                {
                    TestID = 75,
                    CategoryID = 1,
                    Question = "You struggle with deadlines.",
                    Number = 59,
                    PersonalType = "JP"
                },
                new MBTI
                {
                    TestID = 76,
                    CategoryID = 1,
                    Question = "You feel confident that things will work out for you.",
                    Number = 60,
                    PersonalType = "?"
                }
            );
        //Seed Answers
        modelBuilder.Entity<Answer>().HasData(
                new Answer {
                    AnswerID = 1,
                    Title = "Strongly Agree",
                    Score = 3,
                    IsPhoto = false,
                    CategoryID = 1,
                     },
                new Answer {
                    AnswerID = 2,
                    Title = "Agree",
                    Score = 2,
                    IsPhoto = false,
                    CategoryID = 1,
                     },
                new Answer {
                    AnswerID = 3,
                    Title = "Slightly Agree",
                    Score = 1,
                    IsPhoto = false,
                    CategoryID = 1,
                     },
                new Answer {
                    AnswerID = 4,
                    Title = "Neutral",
                    Score = 0,
                    IsPhoto = false,
                    CategoryID = 1,
                     },
                new Answer {
                    AnswerID = 5,
                    Title = "Slightly Disagree",
                    Score = -1,
                    IsPhoto = false,
                    CategoryID = 1,
                     },
                new Answer {
                    AnswerID = 6,
                    Title = "Disagree",
                    Score = -2,
                    IsPhoto = false,
                    CategoryID = 1,
                     },
                new Answer {
                    AnswerID = 7,
                    Title = "Strongly Disagree",
                    Score = -3,
                    IsPhoto = false,
                    CategoryID = 1,
                     },       

                //PHQ-9 Answers

                new Answer {
                    AnswerID = 8,
                    Title = "Not at all",
                    Score = 0,
                    IsPhoto = false,
                    CategoryID = 2,
                     },
                new Answer {
                    AnswerID = 9,
                    Title = "Several days",
                    Score = 1,
                    IsPhoto = false,
                    CategoryID = 2,
                     },
                new Answer {
                    AnswerID = 10,
                    Title = "More than half the days",
                    Score = 2,
                    IsPhoto = false,
                    CategoryID = 2,
                     },
                new Answer {
                    AnswerID = 11,
                    Title = "Nearly every day",
                    Score = 3,
                    IsPhoto = false,
                    CategoryID = 2,
                     },   
                
                //Seed GAD-7 Answers

                new Answer {
                    AnswerID = 12,
                    Title = "Not at all",
                    Score = 0,
                    IsPhoto = false,
                    CategoryID = 3,
                     },
                new Answer {
                    AnswerID = 13,
                    Title = "Several days",
                    Score = 1,
                    IsPhoto = false,
                    CategoryID = 3,
                     },
                new Answer {
                    AnswerID = 14,
                    Title = "Over half the days",
                    Score = 2,
                    IsPhoto = false,
                    CategoryID = 3,
                     },
                new Answer {
                    AnswerID = 15,
                    Title = "Nearly every day",
                    Score = 3,
                    IsPhoto = false,
                    CategoryID = 3,
                },

                //Additional answers

                new Answer {
                    AnswerID = 16,
                    Title = "Light Blue or Green",
                    Score = 1,
                    IsPhoto = true,
                    CategoryID = 4,
                },
                new Answer {
                    AnswerID = 17,
                    Title = "Dark Blue or Yellow",
                    Score = 2,
                    IsPhoto = true,
                    CategoryID = 4,
                },
                new Answer {
                    AnswerID = 18,
                    Title = "Red or Orange",
                    Score = 3,
                    IsPhoto = true,
                    CategoryID = 4,
                },
                new Answer {
                    AnswerID = 19,
                    Title = "Day",
                    Score = 1,
                    IsPhoto = true,
                    CategoryID = 5,
                },
                new Answer {
                    AnswerID = 20,
                    Title = "Night",
                    Score = 2,
                    IsPhoto = true,
                    CategoryID = 5,
                },
                new Answer {
                    AnswerID = 21,
                    Title = "First Avatar",
                    Score = 1,
                    IsPhoto = true,
                    CategoryID = 6,
                },
                new Answer {
                    AnswerID = 22,
                    Title = "Second Avatar",
                    Score = 2,
                    IsPhoto = true,
                    CategoryID = 6,
                },
                new Answer {
                    AnswerID = 23,
                    Title = "Third Avatar",
                    Score = 3,
                    IsPhoto = true,
                    CategoryID = 6,
                },
                new Answer {
                    AnswerID = 24,
                    Title = "Fourth Avatar",
                    Score = 4,
                    IsPhoto = true,
                    CategoryID = 6,
                },
                new Answer {
                    AnswerID = 25,
                    Title = "Sad Image",
                    Score = 0,
                    IsPhoto = false,
                    CategoryID = 7,
                },
                new Answer {
                    AnswerID = 26,
                    Title = "Joyful Image",
                    Score = 0,
                    IsPhoto = false,
                    CategoryID = 8,
                },
                new Answer {
                    AnswerID = 27,
                    Title = "Next 5 years",
                    Score = 0,
                    IsPhoto = false,
                    CategoryID = 9,
                },
                new Answer {
                    AnswerID = 28,
                    Title = "Next 10 years",
                    Score = 0,
                    IsPhoto = false,
                    CategoryID = 10,
                },
                new Answer {
                    AnswerID = 29,
                    Title = "Past 10 years",
                    Score = 0,
                    IsPhoto = false,
                    CategoryID = 11,
                },
                new Answer {
                    AnswerID = 30,
                    Title = "Today",
                    Score = 0,
                    IsPhoto = false,
                    CategoryID = 12,
                },
                new Answer {
                    AnswerID = 31,
                    Title = "Engaging",
                    Score = 0,
                    IsPhoto = false,
                    CategoryID = 13,
                },
                new Answer {
                    AnswerID = 32,
                    Title = "Share with us",
                    Score = 0,
                    IsPhoto = false,
                    CategoryID = 14,
                }
                
            );
    }
}
