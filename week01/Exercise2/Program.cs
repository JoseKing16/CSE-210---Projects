    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the Exercise2 Project.");
            Console.Write("What is your grade porcentage? ");
            string Input = Console.ReadLine();
            float Grade = float.Parse(Input);
            if (Grade >=90)
            {
                Console.WriteLine("A");
            }
            else if (Grade >= 80 && Grade < 90)
            {
                Console.WriteLine("B");
            }
            else if (Grade >= 70 && Grade < 80)
            {
                Console.WriteLine("C");
            }
            else if (Grade >= 60 && Grade <70)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console. WriteLine("F");
            }
            if (Grade >= 70)
            {
                Console.WriteLine("Congratulation! You did it!");
            }
            else
            {
                Console.WriteLine("Sorry. Good luck the next time");
            }

        }
}