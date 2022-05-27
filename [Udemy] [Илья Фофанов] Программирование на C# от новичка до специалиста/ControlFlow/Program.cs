using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //DZ_4();
            //Loops();
            //Debug();
            //DZ_05();
            //DZ_06();
            //Factorial();
            //DZ_07();
        }

        static void DZ_07()
        {
            string password = "qwerty";
            string login = "aleksey";
            int tries = 1; 
            
            while (tries <= 3)
            {
                Console.WriteLine("enter the login");
                string userLogin = Console.ReadLine();
                
                Console.WriteLine("enter the password"); 
                string  userPassword =  Console.ReadLine();

                if (userLogin == login && userPassword == password)
                {
                    Console.WriteLine("Enter the system");
                    break;
                }
                tries++;
            }
            if (tries == 4)
            {
                Console.WriteLine("You exceeded the number of available tries"); 
            }
            

        }
        static void Factorial()
        {
            Console.WriteLine("Enter n >= 0");  
            int n = int.Parse(Console.ReadLine());

            long factorial = 1;
            for (int i = 1; i < n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
        static void DZ_06()
        {
            
            
            int[] numbers = new int[10];
            int inputCount = 0;
            
            Console.WriteLine("enter 10 numbers");

            while (inputCount < 10)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[inputCount] = number;
                
                inputCount++;

                if (number == 0) break;
            }

            int sum = 0;
            int count = 0;

            foreach (int n in numbers)
            {
                if (n > 0 && n % 3 == 0)
                {
                    sum += count;
                    count++; 
                }
            }
            double average = (double) sum / count;
            Console.WriteLine($"average :{average}");

        }
        static void DZ_05()
        {
            Console.WriteLine("Enter the numbers for fibanachi");
            int n = int.Parse(Console.ReadLine());
            int[] fibonachi = new int[n];

            int a0 = 0;
            int a1 = 1;

            fibonachi[0] = a0;
            fibonachi[1] = a1;

            for (int i = 2;  i < n ; i++)
            {
                int a = a0 + a1;
                fibonachi[i] = a;

                a0 = a1;
                a1 = a;
            }

            foreach (int cur in fibonachi)
            {
                Console.WriteLine(cur);
            }

        }
        static void Debug() 
        {
            Console.WriteLine("Lets calculate the square of a triangle");
            
            Console.WriteLine("Enter the length of side AB");
            double ab = GetDouble();
            
            Console.WriteLine("Enter the length of side BC");
            double bc = GetDouble();
            
            Console.WriteLine("Enter the length of side AC");
            double ac = GetDouble();
            
            double p = ab + bc + ac / 2;
            double square = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
            Console.WriteLine($"Square of teh triangles = {square}");
        }
        static double GetDouble()
        {
            return double.Parse(Console.ReadLine()); 
        }
        static void Loops()
        {
            int[] numbers = {1, 2, 4, 5, 6, 8, 9};

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        static void DZ_4()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            /*int max = a;
            if (b > a)
            {
                max = b;
            }*/
            
            int max = a > b ? a : b;
            Console.WriteLine(max);
        }
    }
}
