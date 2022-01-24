using System;
using System.Text;

namespace CSarpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1;
            a1 = new int[10];
            int[] a2 = new int[5];
            int[] a3 = new int[5] {1, 3, -2, 510 , 8};
            int[] a4 = { 1, 3, 4, 55, 6, 7 };
            Console.WriteLine(a4[0]);

            a4[0] = 777;
            Console.WriteLine(a4[0]);
            Console.WriteLine(a4.Length);
        }

        static void MathDemo()
        {
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Round(1.7));
            Console.WriteLine(Math.Round(1.4));
            Console.WriteLine(Math.Round(1.5));

            Console.WriteLine();
            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));
        }

        static void Comments()
        {
            //a single comment
            /*
             * Multi-kine comment
             * we can write here many words 
             */
        }

        static void CastingAndParsing()
        {
            byte b = 255;

            int i = b;
            long l = i;
            float f = i;

            b = (byte)i;

            Console.WriteLine(b);

            string str = "1";
            int.Parse(str);
            Console.WriteLine(str);

            int x = 5;
            int resault = x / 2;
            Console.WriteLine(resault);

            double resault2 = (double)x / 2;
            Console.WriteLine(resault2);
        }

        static void ConsoleBasics()
        {
            // Console.WriteLine("Hi please tell me your name");

            //string resault = Console.ReadLine();
            // string sentence = $"your name is {resault}";
            // Console.WriteLine(sentence);

            Console.WriteLine("Hi please tell me your age");
            string input = Console.ReadLine();
            int age = int.Parse(input);
            string sentence = $"your age is {age}";
            Console.WriteLine(sentence);

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("New Style ");
            Console.Write("New Style\n ");
            Console.Clear();

        }

        static void ComparingSstrings()
        {
            string str1 = "abcee";
            string str2 = "abcee";
            bool equal = str1 == str2;
            Console.WriteLine(equal);

            equal = string.Equals(str1, str2, StringComparison.Ordinal);
            Console.WriteLine(equal);

            string st1 = "abcee";
            string st2 = "abcee";
            bool areEqual;

            areEqual = string.Equals(st1, st2, StringComparison.Ordinal);
            Console.WriteLine(areEqual);

            areEqual = string.Equals(st1, st2, StringComparison.InvariantCulture);
            Console.WriteLine(areEqual);

            areEqual = string.Equals(st1, st2, StringComparison.CurrentCulture);
            Console.WriteLine(areEqual);
        }

        static void StringFormat()
        {
            string name = "Aleksey";
            int age = 36;
            string str1 = string.Format("My name is {0} and I am {1}", name, age);
            string str2 = $"My name is {name} and I am {age}";
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            string str3 = "My name is \n Aleksey";
            string str4 = "I am \t 30";
            Console.WriteLine(str3);
            Console.WriteLine(str4);

            str3 = $"My name is {Environment.NewLine} John";
            Console.WriteLine(str3);

            string str5 = "I am Aleksey and I am a \"good programmer\"";
            Console.WriteLine(str5);

            string str6 = "C:\\tmp\\test_file.txt";
            Console.WriteLine(str6);

            string str7 = @"C:\tmp\test_file.txt";
            Console.WriteLine(str7);


            int answer = 42;
            string resault = string.Format("{0:d}", answer);
            string resault2 = string.Format("{0:d4}", answer);
            Console.WriteLine(resault);
            Console.WriteLine(resault2);

            string resault3 = string.Format("{0:f}", answer);
            string resault4 = string.Format("{0:f4}", answer);
            Console.WriteLine(resault3);
            Console.WriteLine(resault4);

            Console.OutputEncoding = Encoding.UTF8;

            double money = 12.8;
            string resaultNew1 = string.Format("{0:C}", money);
            string resaultNew2 = string.Format("{0:C2}", money);
            Console.WriteLine(resaultNew1);
            Console.WriteLine(resaultNew2);
        }

        static void StringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is Aleksey ");
            sb.AppendLine("!");
            sb.Append("Hello");

            string str = sb.ToString();
            Console.WriteLine(str);

            double money = 12.7;
            string interMoney = $"{money:C2}";
            Console.WriteLine(interMoney);

        }    

        static void StringModification() {
            string nameConcat = string.Concat("My ", "name ", "is ", "Aleksey ");
            Console.WriteLine(nameConcat);

            nameConcat = string.Join(" ", "My", "name", "is", "Alex");
            Console.WriteLine(nameConcat);

            string newName = nameConcat.Insert(0, "by the way, ");
            Console.WriteLine(newName);

            nameConcat = nameConcat.Remove(5, 1);
            Console.WriteLine(nameConcat);

            string replcaed = nameConcat.Replace("n", "z");
            Console.WriteLine(replcaed);

            string data = "12;28:56:78:44:77";
            string[] splitData = data.Split(";");
            string onevalue = splitData[0];
            Console.WriteLine(onevalue);

            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]);

            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);

            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);

            string trimmed = nameConcat.Trim();
            Console.WriteLine(trimmed);
        }

        static void StringEmpinees()
        {
            string strEmpty = string.Empty;
            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = " x";
            string nullString = null;

            bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(isNullOrEmpty);

            Console.WriteLine("==========");
            bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpaced);
            Console.WriteLine(isNullOrWhiteSpace);
        }

        static void QueryingString()
        {
            string name = "lololoytgg";
            bool containsA = name.Contains("a");
            bool containsL = name.Contains("l");

            Console.WriteLine(containsA);
            Console.WriteLine(containsL);

            bool endsWithGG = name.EndsWith("gg");
            Console.WriteLine(endsWithGG);

            bool startsWith = name.StartsWith("lol");
            Console.WriteLine(startsWith);

            int indexOfA = name.IndexOf("t", 1);
            Console.WriteLine(indexOfA);

            int lastIndexOfA = name.LastIndexOf('o');
            Console.WriteLine(lastIndexOfA);

            Console.WriteLine(name.Length);

            string subStr = name.Substring(5);
            string subStr2 = name.Substring(0, 3);

            Console.WriteLine(subStr);
            Console.WriteLine(subStr2);
            
        }

        static void StaticAndInstanceMembers()
        {
            string name = new string("abra codabra");
            bool containsA = name.Contains("a");
            bool containsI = name.Contains("i");

            Console.WriteLine(containsA);
            Console.WriteLine(containsI);

            string abc = string.Concat("a", "b", "c");
            Console.WriteLine(abc);

            Console.WriteLine(int.MinValue);

            int x = 1;

            string xStr = x.ToString();

            Console.WriteLine(x);
            Console.WriteLine(xStr);
        }

        static void Operators()
        {
            int x = 1;
            x = x + 1;
            x++;

            Console.WriteLine(x);

            x += 2;

            Console.WriteLine(x);
        }

        static void Overflow()
        {
            checked
            {
                uint x = uint.MaxValue;
                Console.WriteLine(x);

                x = x + 1;
                Console.WriteLine(x);

                x = x - 1;
                Console.WriteLine(x);
            }
        }

        static void Literals()
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
                //Console.WriteLine(c);

            }

            Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
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
