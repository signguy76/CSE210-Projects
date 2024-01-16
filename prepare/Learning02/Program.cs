using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Job job = new();
        job._jobTitle = "Engineer";
        job._startYear = 2010;
        job._endYear = 2020;
        job.Display();
    }
}