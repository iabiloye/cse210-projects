using System;

class Program
{
    static void Main(string[] args)
    {
  
        Random randomGenerator = new Random();
        int x = randomGenerator.Next(1, 100);
        
        
        int guessNumber = 0;        

        while (guessNumber != x)
        {
            Console.Write("What is your guess? ");
            string userInputGuess = Console.ReadLine();
            guessNumber = int.Parse(userInputGuess);
            
                if (guessNumber < x)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > x)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it! You must have ESPN!(joke) ");
            }
        }

    }
}