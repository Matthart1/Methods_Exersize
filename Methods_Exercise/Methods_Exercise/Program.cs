using System;

namespace Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Whats your name?");
            //string Name = Console.ReadLine();
            //Console.WriteLine($"Your name is {Name}");

            Console.WriteLine("Whats is your name?");
            string Name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string Age = Console.ReadLine();

            //Console.WriteLine($"{Name} is {Age} years old!");
            Console.WriteLine("Where are you from?");
            string Place = Console.ReadLine();

            Console.WriteLine("Whats your greatest accomplishment?");
            string CoolShit = Console.ReadLine();

            Console.WriteLine("Anything else you are proud of?");
            string CoolShitContinued = Console.ReadLine();

            Console.WriteLine($"Tonight we honor {Name}, {Age} years ago the world was blessed with the birth of {Name}. " +
                $"Ever since then the town of {Place} has been a bright and happy place. {Name} is the one you may remember for such things as " +
                $"{CoolShit} and, {CoolShitContinued}. May we remember {Name} always as the great and wonderful person they were.");
        }
    }
}
