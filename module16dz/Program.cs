using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module16dz
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
        }

        private static void SecondTask()
        {
            const string input = "INPUT.txt";
            const string output = "OUTPUT.txt";

            string str;
            using (StreamReader reader = new StreamReader(input))
            {
                str = reader.ReadLine();
            }
            var numbers = GetNumbers(str);
            int sum = 0;
            numbers.ForEach(number => sum += number);
            using (StreamWriter writer = new StreamWriter(output))
            {
                writer.Write(sum);
            }
        }

        private static List<int> GetNumbers(string str)
        {
            List<int> numbers = new List<int>();
            string tmp = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    tmp += str[i];
                }
                else
                {
                    numbers.Add(int.Parse(tmp));
                    tmp = "";
                }
            }
            numbers.Add(int.Parse(tmp));
            return numbers;
        }
        private static void FirstTask()
        {
            const string PATH = "Fibonacci numbers.txt";
            string str;
            using (StreamReader reader = new StreamReader(PATH))
            {
                str = reader.ReadLine();
            }

            var numbers = GetNumbers(str);
            int count = numbers.Count;

            for (int i = 0; i < count; i++)
            {
                numbers.Add(numbers[i + count - 2] + numbers[i + count - 1]);
            }

            using (StreamWriter writer = new StreamWriter(PATH))
            {
                numbers.ForEach(number => writer.Write(number + " "));
            }
            Console.ReadLine();
        }
    }
}
