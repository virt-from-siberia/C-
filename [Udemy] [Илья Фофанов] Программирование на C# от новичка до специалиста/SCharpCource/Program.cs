using System;
using System.Collections.Generic;
using System.Text;


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
            //QueryString()
            //StringEmptiness()
            //StringModification()
            //StringForm()
            //StringFormat()

            string str1 = "abcde";
            string str2 = "abcde";

            bool areEqual = str1 == str2;
            Console.WriteLine(areEqual);

            string.Equals(str1, str2, StringComparison.Ordinal);

            string s1 = "Stresse";
            string s2 = "Stresse2";
        }

        static void StringFormat()
        {
            double answer = 42.8;

            /*string result = string.Format("{0:d}", answer);
            Console.WriteLine(result);
            
            string result2 = string.Format("{0:d4}", answer);
            Console.WriteLine(result2);*/

            string result3 = string.Format("{0:f}", answer);
            Console.WriteLine(result3);

            string result4 = string.Format("{0:f1}", answer);
            Console.WriteLine(result4);

            Console.OutputEncoding = Encoding.UTF8;

            double money = 12.8;
            string result = string.Format("{0:C}", money);
            string result2 = string.Format("{0:C2}", money);

            Console.WriteLine(result);
            Console.WriteLine(result2);

            var result5 = $"{money:C2}";
            Console.WriteLine(result5);
        }

        static void StringForm()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("Aleks ");

            string str = sb.ToString();
            Console.WriteLine(str);

            string str5 = "I am Alex and \"good\" programmer";
            Console.WriteLine(str5, " !!!");

            string str6 = "C:\\tmp\\text_file.txt";
            Console.WriteLine(str6);

            string str7 = @"C:\tmp\text_file.txt";
            Console.WriteLine(str7);

            int age = 36;
            string name = "Alex";
            string str1 = string.Format("My name is {0} and I am {1}", name, age);
            Console.WriteLine(str1);

            string str2 = $"My name is {name} and I am {age}";
            Console.WriteLine(str2);

            string str3 = "my name is \n John";
            Console.WriteLine(str3);

            str3 = $"My name is {Environment.NewLine} Aleks !";
            Console.WriteLine(str3);
        }

        static void StringModification()
        {
            string nameConcat = string.Concat("My", "name", "is");
            Console.WriteLine(nameConcat);

            nameConcat = string.Join(" ", "My", "name", "is");
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Insert(0, "By the way");
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Remove(0, 1);
            Console.WriteLine(nameConcat);

            string replaced = nameConcat.Replace("n", "z");
            Console.WriteLine(replaced);

            string data = "12;23;345;57;345";
            string[] splitData = data.Split(';');

            foreach (var item in splitData)
            {
                Console.WriteLine(item);
            }

            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]);

            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);

            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);

            string trim = " My name is Aleksey  ";
            Console.WriteLine(trim.Trim());
        }

        static void StringEmptiness()
        {
            string str = string.Empty;
            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = " b";
            string nullString = null;

            Console.WriteLine("isNullOrEmpty");

            bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullOrEmpty);

            Console.WriteLine();
            Console.WriteLine("IsNullOrWhiteSpace");

            bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullOrWhiteSpace);

            Console.WriteLine();
        }

        static void QueryString()
        {
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

            string substrFromTwo = name.Substring(0, 3);
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