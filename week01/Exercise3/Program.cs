using System;

class Program
{
    
    static void Main(string[] args)

    {
        string UserAnswer = "";
        
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        //Generated a magic number
        Random randomGenerator = new Random();
        int Number = randomGenerator.Next(1,2);
        do  
            {
                int Count = 1;
                //Promt the user to guess the number.
                Console.Write("Guess the number between 1-100: ");
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
                    else
                    {
                        Console.WriteLine($"Congratulation! {Guess} is the magic number.");
                    }
                    guess = Console.ReadLine();
                    Guess = int.Parse(guess);
                    Count ++;
                }

                Console.WriteLine($"You tried {Count} times");
                Console.WriteLine("");

                //Asks to play again or end the game
                Console.Write("Would you like to play again? [yes/no]: ");
                UserAnswer = Console.ReadLine();
            } while (UserAnswer == "yes" || UserAnswer == "y");
        
        Console.WriteLine("Thank you for playing");
        
            
        
    }
}