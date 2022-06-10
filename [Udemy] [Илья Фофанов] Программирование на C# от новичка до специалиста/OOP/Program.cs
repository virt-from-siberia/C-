using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstParticle();
            //ServiceContract();
            //Arguments();
            //NullibleParticle();
            //Object();
            //Constructor();
            //Constants();
            //Incapsulation();
            Abstract();

        }

        static void Abstract()
        {
            //Shapes shape = new Shapes;
            Shapes[] shapes = new Shapes[2];
            shapes[0] = new Triangle(10, 20, 30);
            shapes[1] = new Rectangle(5, 10);

            foreach (Shapes shape in shapes)
            {
                shape.Draw();
            }

            Console.ReadLine();
        }
        static void Incapsulation()
        {
            ModelXTerminal terminal = new ModelXTerminal("123");
            terminal.Connect();
            Console.ReadLine();
        }

        static void Constructor()
        {
            Charachter c = new Charachter("Elf");
            Console.WriteLine(c.Race);
        }
        static void Object()
        {
            int x;
            x = 1;
            object obj = x;
            Console.WriteLine(obj);
            int y = (int)obj;

            double pi = 3.14;
            object obj1 = pi;
            int number = (int)(double)obj1;
        } 
        static void DoSomething(object obj)
        {
            bool isPointRef = obj is PointRef;
            if (isPointRef)
            {
                PointRef pr = (PointRef) obj;
                Console.WriteLine(pr.x);
            }

            PointRef pr1 = obj as PointRef;
            if (pr1 != null)
            {
                Console.WriteLine(pr1.x); 
            }

        }
        static void NullibleParticle()
        {

            PointVal? pv = null;
            PointRef c = new PointRef();
            Console.WriteLine(c.x);
        }
        static void Arguments()
        {
            int a = 1;
            int b = 2;
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a} ;  b = {b}");
            Console.ReadLine();
            
            List<int> list = new List<int>();
            AddNumbers(list);

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }
        static void Swap(ref int a, ref int b)
        {
            Console.WriteLine($"original a = {a} ;  b = {b}");
            (a, b) = (b, a);
            Console.WriteLine($"swapped a = {a} ;  b = {b}");
        }
        static void ServiceContract()
        {
            PointVal a;
            a.x = 5;
            a.y = 3;

            PointVal b = a;
            b.x = 10;
            b.y = 10;
            
            a.LogValues();
            b.LogValues();
            a.LogValues();

            Console.WriteLine("After Structs");

            PointRef c = new PointRef {x = 5, y = 3};
            PointRef d = c;
            d.x = 10;
            d.y = 10;
            
            c.LogValues();
            d.LogValues();

        }
        static void FirstParticle()
        {
            Charachter c = new Charachter("Lol");
            Charachter c1 = new Charachter("Lol");
            Charachter c2= new Charachter("Lol");
            c.Hit(120);
            Console.WriteLine(c.Health);
            
            Calculator calculator = new Calculator();
            double sque1 = calculator.CalcTriangleSquare(10, 20);
            double sque2 = calculator.CalcTriangleSquare(10, 20, 30);
            double sque3 = calculator.CalcTriangleSquare(10, 20, 30, true);

            Console.WriteLine($"square 1 = {sque1}");
            Console.WriteLine($"square 2 = {sque2}");
            Console.WriteLine($"square 3 = {sque2}");

            Console.WriteLine(RomanNumeral.Parse("XIV"));
            double avg = calculator.Average2(1,2,3,4);

            Console.WriteLine("Enter a number");
            string line = Console.ReadLine();
            
            bool wasParsed = int.TryParse(line, out int number);
            if (wasParsed)
                Console.WriteLine(number);
            else
                Console.WriteLine("Failed to parse");


            if ( calculator.TryDivide(0 , 2, out double result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Failed to divide");
            }
            Console.ReadLine();
            
            c1.IncreaceSpeed();

            Console.WriteLine($"c1.Speed = {c1.PrintSpeed()}");
            Console.WriteLine($"c2.Speed = {c2.PrintSpeed()}");
        }
    }
} 
