#nullable disable

using System;

namespace MadLibGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter color: ");
            string color = Console.ReadLine();

            Console.Write("Enter plural noun: ");
            string pluralNoun = Console.ReadLine();

            Console.Write("Enter celebrity: ");
            string celebrity = Console.ReadLine();

            Console.WriteLine($"Roses are {color}");
            Console.WriteLine($"{pluralNoun} are blue");
            Console.WriteLine($"I love {celebrity}");


        }
    }

}