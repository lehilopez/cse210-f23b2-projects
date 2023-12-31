using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int number = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = 0;
        int counter = 0; 

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            counter++;           
            
            if (number > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (number < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
        }

        Console.Write($"You tried {counter} time(s).");
    }
}