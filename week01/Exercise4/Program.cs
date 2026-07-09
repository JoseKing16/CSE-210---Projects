using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List <string> numbers = new List <string>{};
        int Total = 0;
        int Average = 0;
        string UserInput = "";
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

        //Adds numbers type by the user into the list.


        //Reads the list.
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
            //this line bellow changes the value of the numbers in the list from strings to int.
            int Number = int.Parse(number);
            Total += Number;
            Average += Number;
        }
        Average = (Average/numbers.Count());
        Console.WriteLine(Total);
        Console.WriteLine(Average);
        Console.WriteLine(numbers.Count());
    }
}