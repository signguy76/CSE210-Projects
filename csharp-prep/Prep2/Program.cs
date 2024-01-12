using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string yourGrade = Console.ReadLine();
        int yourGradeNumber = int.Parse (yourGrade);
        // Test parse 
        Console.Write($"At {yourGradeNumber}%, ");
        if (yourGradeNumber > 90 || yourGradeNumber == 90)
        {
            string letter = "A";           
            Console.WriteLine ($"your grade is an {letter}.");
        }
        else if (yourGradeNumber < 90 && yourGradeNumber > 80 || yourGradeNumber == 80)
        {
            string letter = "B";
            
            Console.WriteLine ($"your grade is a {letter}.");
        }else if (yourGradeNumber < 80 && yourGradeNumber > 70 || yourGradeNumber == 70)
        {
            string letter = "C";
            Console.WriteLine ($"your grade is a {letter}.");
        }
        else if (yourGradeNumber < 70 && yourGradeNumber > 60 || yourGradeNumber == 60)
        {
            string letter = "D";
            Console.WriteLine ($"your grade is a {letter}.");
        }
        else if (yourGradeNumber < 60 )
        {
            string letter = "F";
            Console.WriteLine ($"your grade is an {letter}.");
        }
        {
            Console.WriteLine ($"letter");
        }
        
        
    }
}