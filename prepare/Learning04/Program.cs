using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";

 
        List<int> numbers = new List<int>();

       
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userInput != "0")
        {
            
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);

            if (userNumber !=0)
            {
                numbers.Add(userNumber);
            }
            
        }
       
        float total = numbers.Sum();
        Console.WriteLine($"The sum is: {total}");
        
        float count = numbers.Count();
        float average = total / count;
        Console.WriteLine($"The average is: {average}");

        
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        

        
        
    }
}