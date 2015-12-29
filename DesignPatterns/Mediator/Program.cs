using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public static class MediatorDemo
    {
        public static void Main()
        {
            var human = new Brain();

            string line;
            AskForInput();
            while (!string.IsNullOrEmpty(line = Console.ReadLine()))
            {
                switch (line)
                {
                    case "Ear":
                        human.Ear.HearSomething();
                        break;
                    case "Eye":
                        human.Eye.SeeSomething();
                        break;
                    case "Hand":
                        human.Hand.FeelSomething();
                        break;
                }
                AskForInput();
            }
        }

        private static void AskForInput()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter body part ('Ear','Eye','Hand' or empty to exit):");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
    }
}

