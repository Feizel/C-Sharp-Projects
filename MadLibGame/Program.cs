using System;

namespace MadLibGame
{
    class Program
    {
        private static void Main(string[] args)
        {
            string colour, plural_noun, celebrity;

            Console.WriteLine("Enter a colour: ");
            colour = Console.ReadLine();

            Console.WriteLine("Enter a plural noun: ");
            plural_noun = Console.ReadLine();

            Console.WriteLine("Enter a celebrity\'s name that you like: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are {colour}");
            Console.WriteLine("{plural_noun} are blue");
            Console.WriteLine("I love {celebrity}");

        }
    }

}