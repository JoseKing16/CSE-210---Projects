using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int SquaredUserNumber = SquareNumber(UserNumber);

        Console.WriteLine($"{UserName}, the square of your number is {SquaredUserNumber}");
    }
    // Displays a welcome message.
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    //Asks user's name.
    static string PromptUserName()
    {
        Console.Write("May I have your name? ");
        return Console.ReadLine();
    }
    //Asks user's favorite whole number.
    static int PromptUserNumber()
    {
            Console.Write("What is your favorite interger number? ");
            string userNumber = Console.ReadLine();
            int UserNumber = int.Parse(userNumber);
            return UserNumber;
    }
    //Computes the user's squared favorite number
    static int SquareNumber(int UserNumber)
    {
        return UserNumber*UserNumber;
    }
}