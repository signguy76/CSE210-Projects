using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1, 25);
        
        
        Console.WriteLine($"Guess the magic number between 1 and 25.");
        
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