using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
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
            //InheritanceExample();
            //Abstract();
            //Interfaces();
            //isA();
            //Stack();
            //forEach();
            //Exeptions();
            //Files();
            //Folders();
            //DZ_01();
            DZ_02();
        }

        static void DZ_02()
        {
            GuessNumberGame game = new GuessNumberGame(guessingPlayer: GuessingPlayer.Human);
            game.Start();
        }

        static void DZ_01()
        {
            Complex c1 = new Complex(1, 1);
            Complex c2 = new Complex(1, 2);

            Complex result = c1.Plus(c2);
            Console.WriteLine(result.Imagenary);
            Console.WriteLine(result.Real);
        }

        static void Folders()
        {
            try
            {
                File.Copy("test.txt", "test_copy.txt", overwrite: true);
                if (File.Exists("test_copy_renamed.txt"))
                    File.Delete("test_copy_renamed.txt");
                if (File.Exists("test_copy.txt"))
                    File.Move("test_copy.txt", "test_copy_renamed.txt");

                bool existsDir = Directory.Exists(@"C:\Activators");
                Console.WriteLine(existsDir);

                if (existsDir)
                {
                    IEnumerable<string> files =
                        Directory.EnumerateFiles(@"C:\Activators", "*.jpg", SearchOption.AllDirectories);
                    foreach (var file in files)
                    {
                        Console.WriteLine(file);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        static void Files()
        {
            string[] allLines = File.ReadAllLines("test.txt");

            IEnumerable<string> lines = File.ReadLines("test.txt");
            File.WriteAllText("test_2.txt", "My Name is Alex");
            File.WriteAllLines("test_2.txt", new string[] {"My name", "is Ivan"});
            File.WriteAllBytes("test_3.txt", new byte[] {72, 101, 108, 111, 205});

            Console.WriteLine(allLines);

            string allText = File.ReadAllText("test_2.txt");
            Console.WriteLine(allText);

            byte[] bytes = File.ReadAllBytes("test_3.txt");
            Console.WriteLine(bytes);
            Console.WriteLine(Encoding.ASCII.GetString(bytes));

            Console.ReadLine();
            Stream fs = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.Write);

            try
            {
                string str = "Hello World";
                byte[] strInBytes = Encoding.ASCII.GetBytes(str);
                fs.Write(strInBytes, 0, strInBytes.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error {e}");
            }
            finally
            {
                fs.Close();
            }

            Console.WriteLine("Now reading");

            using (Stream readingStream = new FileStream("test.txt", FileMode.Open, FileAccess.Read))
            {
                byte[] temp = new byte[readingStream.Length];
                int bytesToRead = (int) readingStream.Length;
                int bytesRead = 0;

                while (bytesToRead > 0)
                {
                    int n = readingStream.Read(temp, bytesRead, bytesToRead);

                    if (n == 0)
                        break;

                    bytesRead += n;
                    bytesToRead -= n;
                }

                string str = Encoding.ASCII.GetString(temp, 0, temp.Length);
                Console.WriteLine(str);

                Console.ReadLine();
            }
        }

        static void Exeptions()
        {
            FileStream file = null;
            try
            {
                file = File.Open("temp.txt", FileMode.Open);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (file != null)
                    file.Dispose();
            }

            Console.WriteLine("Please enter a number");
            string result = Console.ReadLine();

            int number = 0;
            try
            {
                number = int.Parse(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Format exeption has occured");
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine(number);
        }

        static void forEach()
        {
            var ms = new MyStack<int>();
            ms.Push(1);
            ms.Push(2);
            ms.Push(3);

            foreach (var item in ms)
            {
                Console.WriteLine(item);
            }
        }

        static void Stack()
        {
            var ms = new MyStack<int>();
            ms.Push(1);
            ms.Push(2);
            ms.Push(3);

            Console.WriteLine(ms.Count);
            Console.WriteLine(ms.Pick());

            ms.Pop();
            Console.WriteLine(ms.Pick());

            ms.Push(3);
            ms.Push(4);
            ms.Push(5);
        }

        static void isA()
        {
            // Rect rect = new Rect{ Height = 0, Width = 5 };
            // int rectArea = AriaCalculator.CalcSquare(rect);
            // Console.WriteLine($"React aria = {rectArea}");
            //
            // Rect square = new Square { Height = 2 , Width = 10 };
            // AriaCalculator.CalcSquare(square);
            IShape react = new Rect() {Height = 2, Width = 5};
            IShape square = new Square() {SideLength = 2};

            Console.WriteLine(react.CalcSquare());
            Console.WriteLine(square.CalcSquare());
        }

        static void Interfaces()
        {
            List<object> list = new List<object>() {1, 2, 3};
            IBaseCollection collection = new BaseList(4);
            collection.Add(list);
            collection.Add(1);
        }

        static void Abstract()
        {
            Shape[] shapes = new Shape[2];
            shapes[0] = new Triangle(10, 20, 30);
            shapes[1] = new Rectangle(5, 10);

            foreach (Shape shape in shapes)
            {
                shape.Draw();
                Console.WriteLine(shape.Perimeter());
            }
        }

        static void InheritanceExample()
        {
            ModelXTerminal terminalX = new ModelXTerminal("123");
            terminalX.Connect();
            Console.ReadLine();
        }

        static void Constructor()
        {
            Charachter c = new Charachter("Elf");
            Console.WriteLine(c.Race);
        }

        static void Object()
        {
            int x = 1;
            object obj = x;
            Console.WriteLine(obj);
            int y = (int) obj;

            double pi = 3.14;
            object obj1 = pi;
            int number = (int) (double) obj1;
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
            int tmp = a;
            a = b;
            b = tmp;
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
            Charachter c2 = new Charachter("Lol");
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
            double avg = calculator.Average2(1, 2, 3, 4);

            Console.WriteLine("Enter a number");
            string line = Console.ReadLine();

            bool wasParsed = int.TryParse(line, out int number);
            if (wasParsed)
                Console.WriteLine(number);
            else
                Console.WriteLine("Failed to parse");


            if (calculator.TryDivide(0, 2, out double result))
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