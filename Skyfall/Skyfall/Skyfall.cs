using System;
using Thunderball;

namespace Skyfall
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Civilization Name: ");
            string name = Console.ReadLine();
            Civ tball = new Civ(name);
            Console.WriteLine(tball.getName());
            tball.Weakness();
        }
    }
}
