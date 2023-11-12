namespace Dz3
{

    public class Task1
    {
        public static void Run()
        {
            Console.WriteLine("Task 1 was removed!");
        }
    }

    public class Task2
    {
        public static void Run()
        {
            string str = "London, Paris, Rome";
            char separator = ',';

            List<string> result = new List<string>();
            int startIndex = 0;
            int separatorIndex = str.IndexOf(separator);

            while (separatorIndex != -1)
            {
                string substring = str.Substring(startIndex, separatorIndex - startIndex);
                result.Add(substring);
                startIndex = separatorIndex + 1;
                separatorIndex = str.IndexOf(separator, startIndex);
            }

            string lastSubstring = str.Substring(startIndex);
            result.Add(lastSubstring);

            string[] resultArray = result.ToArray();

            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write(resultArray[i]);
            }
        }
    }

    public class Task3
    {
        public static void Run()
        {
            Console.WriteLine("Enter your string: ");
            string str = Console.ReadLine();

            Console.WriteLine("Enter substring, that you want to find: ");
            string substr = Console.ReadLine();

            bool found = false;

            for (int i = 0; i <= str.Length - substr.Length; i++)
            {
                if (str.Substring(i, substr.Length) == substr)
                {
                    found = true;
                    Console.WriteLine("Substring '{0}' has been founded", substr);
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Substring '{0}' has not been founded", substr);
            }

        }
    }

    public class Task4
    {
        static string[] units = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
        static string[] teens = { "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
        static string[] tens = { "", "", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
        static string[] thousands = { "", "тысяча", "тысячи", "тысяч" };
        public static void Run()
        {
            int number;
            Console.Write("Введите число: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine(NumberToWords(number));
            }
            else
            {
                Console.WriteLine("Некорректный ввод числа.");
            }
        }

        static string NumberToWords(int number)
        {
            if (number == 0)
            {
                return units[0];
            }

            if (number < 0)
            {
                return "минус " + NumberToWords(Math.Abs(number));
            }

            string words = "";

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " " + thousands[number / 1000] + " ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += units[number / 100] + " сто ";
                number %= 100;
            }

            if (number >= 10 && number <= 19)
            {
                words += teens[number - 10];
            }
            else
            {
                words += tens[number / 10] + " " + units[number % 10];
            }

            return words;
        }
    }

    public class Task5
    {
        public static void Run()
        {
            Console.Write("Input a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("a = {0}; b = {1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine("Swap completed: ");
            Console.WriteLine("a = {0}; b = {1}", a, b);
        }
        public static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1-5 to open the task number: ");
            int choice = Int32.Parse(Console.ReadLine());


            if (choice == 1)
            {
                Console.WriteLine();
                Task1.Run();
            }
            else if (choice == 2)
            {
                Console.WriteLine();
                Task2.Run();
            }
            else if (choice == 3)
            {
                Console.WriteLine();
                Task3.Run();
            }
            else if (choice == 4)
            {
                Console.WriteLine();
                Task4.Run();
            }
            else if (choice == 5)
            {
                Console.WriteLine();
                Task5.Run();
            }
            else
            {
                Console.WriteLine("\nExiting program.");
            }
        }
    }
}