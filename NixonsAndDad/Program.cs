using System;

namespace NixonsAndDad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. What is your name?");
            var myName = Console.ReadLine();
            Console.WriteLine($"Hey {myName} how are you?");
            var response = Console.ReadLine();
            Console.WriteLine($"Thats great to hear {myName} im glad your {response}.");
            Console.WriteLine("What is your dogs name?");
            var dogs = Console.ReadLine();
            Console.WriteLine($"cool i like {dogs}");
        }
    }
}
