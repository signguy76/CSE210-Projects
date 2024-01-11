using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string g;
        Console.Write("What is your grade percentage? ");
        string yourGrade = Console.ReadLine();
        int yourGradeNumber = int.Parse (yourGrade);
        // Test parse 
        Console.Write($"At {yourGradeNumber} %, ");
        if (yourGradeNumber > 90 || yourGradeNumber == 90)
        {

            g = "A";
            Console.WriteLine ($"your grade is an {g}.");
        }
        else if (yourGradeNumber < 90 && yourGradeNumber > 80 || yourGradeNumber == 80)
        {
            g = "B";
            Console.WriteLine ($"your grade is a {g}.");
        }else if (yourGradeNumber < 80 && yourGradeNumber > 70 || yourGradeNumber == 70)
        {
            Console.WriteLine ("your grade is a C.");
        }
        else if (yourGradeNumber < 70 && yourGradeNumber > 60 || yourGradeNumber == 60)
        {
            Console.WriteLine ("your grade is a D.");
        }
        else if (yourGradeNumber < 60 )
        {
            Console.WriteLine ("your grade is and F. Study harder.");
        }
        if ( yourGradeNumber >70 || yourGradeNumber == 70)
        {
            Console.WriteLine ("Congratulations, you have passed the course.");
        }
        else if (yourGradeNumber < 70)
        {
            Console.WriteLine ("A grade of 70% or better is required to pass this course. Please re-enroll to take the class again.");

        }

    }
}