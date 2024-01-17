using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new();
        job1._company = "Crown Graphics";
        job1._jobTitle = "Installation Manager";
        job1._startYear = 1998;
        job1._endYear = 2011;

        Job job2 = new();
        job2._company = "Sign Factory";
        job2._jobTitle = "Salesperson";
        job2._startYear = 2011;
        job2._endYear = 2015;

        Job job3 = new();
        job3._company = "Signs Now";
        job3._jobTitle = "Sales Manager";
        job3._startYear = 2015;
        job3._endYear = 2023;        

        Resume myResume = new Resume();
        myResume._name = "Johnny Williams";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();
    }
}