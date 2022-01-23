using System;

namespace CSarpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0b11;
            int y = 0b01001;
            int k = 0b0001001;
            int m = 0b1000_1001;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);

            Console.WriteLine("------");

            x = 0x1F;
            y = 0xFF0D;
            k = 0x1FAB30FE;
            m = 0x1FAB_30EF;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);

            Console.WriteLine("------");
            Console.WriteLine('\x78');

            Console.WriteLine('\u0420');
            Console.WriteLine('\u0421');
        } 

        static void Variables()
        {
            int x = 25;
            int y;
            y = 2;          

            float f = 1.1f;
            double n = 2.3;
            int x2 = 0;
            int x3 = new int();

            var a = 1;
            var b = 1.2;

            decimal money = 3.0m;

            char s = 'A';
            string name = "John Doe";

            bool canDrive = true;
            bool canDraw = false;

            object obj1 = 1;
            object obj2 = 'B';

            Console.WriteLine(a);
            Console.WriteLine(name);
        }
    }
}
