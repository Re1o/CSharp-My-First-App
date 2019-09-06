using System;
using System.Runtime.CompilerServices;

namespace MyApp
{
    class Program
    {
     
         
          static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Mis sinu nimi on?");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("No tere " + name);
            Console.WriteLine("Millal sina oled sündinud? Kirjuta aasta: ");
            int aasta;
            aasta = int.Parse(Console.ReadLine());
            int vanus = 2019 - aasta;
            Console.WriteLine("sina oled " + vanus + " aastat vana");
            Console.ReadLine();

            



        }   


    }
}
