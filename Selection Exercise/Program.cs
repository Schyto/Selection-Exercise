using System;

namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Number Guessing Game
            var r = new Random();
            var favNumber = r.Next(0, 1001);
            int userInput;

            do
            {
                Console.WriteLine("Pick a number from 1 - 1000");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is too low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (userInput != favNumber);
            //Switch case
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower()) 
            {
                case "math":
                case "calculus":
                    Console.Writeline("I hate Math!");
                    break;
                case "science":
                case "physics":
                case "biology":
                    Console.WriteLine("I love science!");
                case "PE":
                    Console.WriteLine("PE is the best!!");
                    break;
                case "history":
                    Console.WriteLine("History is fun,");
                    break;
                case "english":
                    Console.WriteLine("English is boring.");
                    break;
                default:
                    console.writeLine("I don't know that subject");
            }
        }
    }
}
