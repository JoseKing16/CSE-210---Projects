using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List <string> numbers = new List <string>{};
        int Total = 0;
        double Average = 0;
        string UserInput = "";
        int LargestNumber = 0;

        //Prompt user to type numbers until user has finished.
        do
        {
            if (UserInput != "0")
            {
                Console.Write("Please enter a number 1-100, and 0 to quit: ");
                UserInput = Console.ReadLine();

                if (UserInput!= "0")
                {
                    numbers.Add(UserInput);
                }
            }

        }   while (UserInput != "0");

        //Reads the list.
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
            //this line bellow changes the value of the numbers in the list from strings to int.
            int Number = int.Parse(number);
            Total += Number;
            Average += Number;
            if (LargestNumber < Number)
            {
                LargestNumber = Number;
            }
            
        }
        Average = Average/numbers.Count();
        Console.WriteLine($"The total is {Total}");
        Console.WriteLine($"The average is {Average}");
        Console.WriteLine($"The largest number is {LargestNumber}");
        Console.WriteLine($"There are a total of {numbers.Count()} numbers in the list");
    }
}