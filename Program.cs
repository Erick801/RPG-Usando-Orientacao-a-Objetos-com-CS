using System;
using RPG.src;

namespace MyApp 
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior Arus = new Warrior("Arus", 22, "Warrior");
            Wizard  wizard = new Wizard("Clover", 20, "Healer");
            
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(wizard.Attack(1));
        }
    }
}
