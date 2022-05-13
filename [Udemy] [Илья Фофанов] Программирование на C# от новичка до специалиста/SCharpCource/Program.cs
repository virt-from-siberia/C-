using System;
using System.Collections.Generic;

namespace SCharpCource
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables();
            //Literals()
            //VariablesScopes()
            //OverflowException()
            //Static()

            string name = "abracadabra";
            bool containsA = name.Contains("a");
            bool containsE = name.Contains("E");

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            bool andsWithAdra = name.EndsWith("abra");
            Console.WriteLine(andsWithAdra);

            bool startsWithAbra = name.StartsWith("abra");
            Console.WriteLine(startsWithAbra);

            int indexOfA = name.IndexOf('a', 1);
            Console.WriteLine(indexOfA);

            int lastIndexOfR = name.LastIndexOf('r');
            Console.WriteLine(lastIndexOfR);
            
            Console.WriteLine(name.Length);

            string substrFromFive = name.Substring(5);
            Console.WriteLine(substrFromFive);
            
            string substrFromTwo = name.Substring(0 , 3);
            Console.WriteLine(substrFromTwo);

        }

        static void Static()
        {
            string name = "abracadabra";
            bool containsA = name.Contains("a");
            bool containsI = name.Contains("i");

            Console.WriteLine(containsA);
            Console.WriteLine(containsI);

            string abs = string.Concat("a", "b", "c");
            Console.WriteLine(abs);

            Console.WriteLine(int.MinValue);

            int x = 1;

            string xStr = x.ToString();
            Console.WriteLine(xStr);
        }
        static void OverflowException()
        {
            checked
            {
                uint x = uint.MaxValue;
                x = x + 1;
                Console.WriteLine(x);
            
                x = x - 1;
                Console.WriteLine(x);
            }
        }
        static void VariablesScopes()
        {
            var a = 1;
            {
                var b = 2;

                {
                    var c = 3;

                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
        }
        static void Literals()
        {
            int x = 0b11;
            int y = 0b1001;
            int c = 0b0001001;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(c);

            x = 0x1F;
            y = 0xFF0D;
            c = 0x1FAB30EF;
          
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(c);
            Console.WriteLine();
            Console.WriteLine(4.5e2);
            Console.WriteLine(3.1E-1);
            Console.WriteLine('\u0420');
            Console.WriteLine('\u0421');
        }
        static void Variables()
        {
            int x = 5;

            int y;

            y = 2;

            //Int32 x1 = -1;

            //uint z = -1;

            float f = 1.1f;

            double l = 2.3;

            int x2 = 0; 
            
            int x3 = new int();

            var a = 1;

            var b = 1.2;
            
            Dictionary<int, string> dict = new Dictionary<int, string>();

            //var v;

            decimal money = 3.0m;

            char @char = 'A';

            string ololo = "John";

            bool canDraw = false;

            object obj = 1;
            
            object obj2 = "2";

            Console.WriteLine(a);
        }
    }
} 