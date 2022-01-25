using System;

namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
       
        }

        static void Switch()
        {
            int widdingYear = int.Parse(Console.ReadLine());

            string name = string.Empty;

            switch (widdingYear)
            {
                case 5:
                    name = "Деревянная свадьба";
                    break;
                case 10:
                    name = "Оловянная свадьба";
                    break;
                case 15:
                    name = "Хрустальная свадьба";
                    break;
                case 25:
                    name = "Фарфоравая свадьба";
                    break;
                case 35:
                    name = "Жемчужная свадьба";
                    break;
                default:
                    break;
            }

            Console.WriteLine(name);
        }

        static void DoWhile() {
            int age = 30;

            while (age < 18)
            {
                Console.WriteLine("What is you age ?");
                age = int.Parse(Console.ReadLine());
            }

            do
            {
                Console.WriteLine("What is you age ?");
                age = int.Parse(Console.ReadLine());
            }
            while (age < 18);
        }

        static void NestedFor()
        {
            int[] numbers = { 1, -2, 4, -7, 4, 6, 7 - 8, -4, 677 };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). indexes ({i}:{j})");
                    }
                }
            }
        }

        static void For()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            foreach (int val in numbers)
            {
                Console.WriteLine(val);
            }
        }

        static void HomeWork05()
        {
            Console.WriteLine("Enter min value");
            int val1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter max value");
            int val2 = int.Parse(Console.ReadLine());

            int resault = val1 > val2 ? val1 : val2;
            Console.WriteLine(resault);
        }

        static void HomeWork04()
        {
            Console.WriteLine("Enter weight");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height");
            double height = double.Parse(Console.ReadLine());

            double bodyMassIndex = weight / (height * height);

            bool isToLow = bodyMassIndex <= 18.5;
            bool isNormal = bodyMassIndex > 18.5 && bodyMassIndex < 25;
            bool isAboveNormal = bodyMassIndex >= 25 && bodyMassIndex <= 30;
            bool isTooFat = bodyMassIndex > 30;
            bool isFat = isAboveNormal || isTooFat;

            if (isFat)
                Console.WriteLine("You are fat");
            else
                Console.WriteLine("You are in good shape");

            if (!isFat)
            {
                Console.WriteLine("You are not fat");
            }

            if (isToLow)
            {
                Console.WriteLine("Not enough weight");
            }
            else if (isNormal)
            {
                Console.WriteLine("you are ok");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("you are is above normal");
            }
            else
            {
                Console.WriteLine("you are fat");
            }
        }
    }
}
