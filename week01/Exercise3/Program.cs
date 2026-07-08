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
        Console.Write("Guess the number between 6-15: ");
        string guess = Console.ReadLine();
        //Storage the number promted into an int variable.
        int Guess = int.Parse(guess);
        while (Guess != Number)
            {
                if (Guess < Number)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please choose a higher number");
                    Console.Write("Please, type another guess: ");
                }
                else if (Guess > Number)
                {
                    Console.WriteLine("");
                    Console.WriteLine("The magic number is lower than this one");
                    Console.Write("Please, type another guess: ");
                }
                guess = Console.ReadLine();
                Guess = int.Parse(guess);
            }
        Console.WriteLine($"Congratulation! {Guess} is the magic number.");
        
    }
}