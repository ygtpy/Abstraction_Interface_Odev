using System;
using Abstraction_Assignment.Classes;
using Abstraction_Assignment.Interfaces;


namespace Abstraction_Assignment
{
    class Program
    {
        static void Main()
        {
            Bmw bmw = new Bmw();
            Mercedes mercedes = new Mercedes();
            Prosche porsche = new Prosche();

            Console.Write("BMW: ");
            bmw.Drive();
            bmw.Float();
            bmw.Fly();
            Console.WriteLine();


            Console.Write("Mercedes: ");
            mercedes.Float();
            mercedes.Fly();
            Console.WriteLine();


            Console.Write("Porsche: ");
            porsche.Fly();
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}