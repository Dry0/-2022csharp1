﻿namespace Functionsopdr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //eerst even uit de static ontsnappen
            Program program = new Program();

            string report = program.AskYourAge();//3) roep hier de function aan

            //1) zet deze 3 regels in een function (AskForAge) in program, en roep deze aan 
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine($"You're age is {age}");
            //eind


        }

        private void AskForAge ()
        {
            Console.WriteLine("What is your age?");

            string age = Console.ReadLine();

            Console.WriteLine($"You're age is {age}");
        }

        //2) maak hier je function met naam AskForAge
        private string AskYourAge()
        {
            string report = "What is your age";


            return report;

            Console.WriteLine(report);
        }
    }
}