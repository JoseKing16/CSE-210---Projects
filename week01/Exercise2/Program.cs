    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the Exercise2 Project.");
            Console.Write("What is your grade porcentage? ");
            string Input = Console.ReadLine();
            float Grade = float.Parse(Input);
            string Letter = "";
            if (Grade >=90)
            {
                Letter = "A";
            }
            else if (Grade >= 80 && Grade < 90)
            {
                Letter = "B";
            }
            else if (Grade >= 70 && Grade < 80)
            {
                Letter = "C";
            }
            else if (Grade >= 60 && Grade <70)
            {
                Letter = "D";
            }
            else
            {
                Letter = "F";
            }
            
            if (Letter == "A" ||Letter == "B" ||Letter == "C" )
            {
                Console.WriteLine("Congratulation! You did it!");
            }
            else
            {
                Console.WriteLine("Sorry. Good luck the next time");
            }

        }
}