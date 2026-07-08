using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        //Takes the magic number from the first player.
        Console.Write("Please choose your magic number between 6-15: ");
        string number = Console.ReadLine();
        //Storage the magic number into an int variable.
        int Number =int.Parse(number);
        //Promt the user to guess the number.
        Console.Write("Guess the number: ");
        string guess = Console.ReadLine();
        //Storage the number promted into an int variable.
        int Guess = int.Parse(guess);

        if (Guess < Number)
        {
            Console.WriteLine("Please choose a higher number");
        }
        else if (Guess > Number)
        {
            Console.WriteLine("The magic number is lower than this one");
        }
        else
        {
            Console.WriteLine($"Congratulation! {Guess} is the magic number.");
        }
        
    }
}