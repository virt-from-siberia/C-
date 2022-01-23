using System;
using System.Text;

namespace CSarpCourse
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is Aleksey ");
            sb.AppendLine("!");
            sb.Append("Hello");

            string str = sb.ToString();
            Console.WriteLine(str);

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
