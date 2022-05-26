using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Charachter c = new Charachter();
            c.Hit(120);
            Console.WriteLine(c.Health);
            
            Calculator calculator = new Calculator();
            double sque1 = calculator.CalcTriangleSquare(10, 20);
            double sque2 = calculator.CalcTriangleSquare(10, 20, 30);

            Console.WriteLine($"square 1 = {sque1}");
            Console.WriteLine($"square 2 = {sque2}");

            Console.WriteLine(RomanNumeral.Parse("XIV"));

            double avg = calculator.Average2(1,2,3,4);

        }
    }
} 
