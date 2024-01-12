using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"{num}");
        
        int guess = -1;
        while (guess != num)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (num > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (num < guess)
            {
                Console.WriteLine("Lower.");    
            }
            else
            {
                Console.WriteLine("You have guessed right!");
            }
            
                
            

        }
    }
}