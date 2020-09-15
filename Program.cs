using System;

namespace Typing
{
    class Program
    {
        static void Main(string[] args)
        {

            string EnterText;
            string EnterCheckText;
            Console.Write("Enter Text : ");
            EnterText = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            while (true)
            {
                if (true)
                {
                    Console.Write("Text : ");
                    EnterCheckText = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
                if (EnterText == EnterCheckText)
                {
                    System.Console.WriteLine(EnterText);
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                else
                {
                    Console.WriteLine(EnterText);
                    Console.ForegroundColor = ConsoleColor.Red;
                }
            }
        }
    }
}
