using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] array1 = { 1, 2, 3, 4, 5, 5, 6, 6, 7, 8, 9, 9 };
            int evenCount = 0;
            int oddCount = 0;
            int uniqueCount = 0;

            foreach (int num in array1)
            {
                if (num % 2 == 0) 
                    evenCount++;
                else 
                    oddCount++;

                if (array1.Count(n => n == num) == 1) 
                    uniqueCount++;
            }

            Console.WriteLine("Задание 1:");
            Console.WriteLine("Количество чётных элементов: " + evenCount);
            Console.WriteLine("Количество нечётных элементов: " + oddCount);
            Console.WriteLine("Количество уникальных элементов: " + uniqueCount);
            Console.WriteLine();

            Console.WriteLine("Задание 2:");
            Console.WriteLine("Введите число:");
            int userNumber = int.Parse(Console.ReadLine());
            int[] array2 = { 2, 4, 6, 8, 10 };

            int countLessThanUserNumber = array2.Count(num => num < userNumber);
            Console.WriteLine("Количество значений меньше " + userNumber + ": " + countLessThanUserNumber);
            Console.WriteLine();

            Console.WriteLine("Задание 3:");
            Console.WriteLine("Введите три числа через пробел:");
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array3 = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };

            int sequenceCount = 0;
            for (int i = 0; i <= array3.Length - 3; i++)
            {
                if (array3.Skip(i).Take(3).SequenceEqual(sequence))
                    sequenceCount++;
            }
            Console.WriteLine("Количество повторений последовательности: " + sequenceCount);
            Console.WriteLine();


            Console.WriteLine("Задание 4:");
            int[] array4_1 = { 1, 2, 3, 4, 5 };
            int[] array4_2 = { 4, 5, 6, 7, 8 };

            int[] array4_3 = array4_1.Intersect(array4_2).ToArray();
            Console.WriteLine("Общие элементы двух массивов без повторений:");
            foreach (int num in array4_3)
            {
                Console.Write(num + " ");
            }

            int[,] array5 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
            int minVal = int.MaxValue;
            int maxVal = int.MinValue;

            for (int i = 0; i < array5.GetLength(0); i++)
            {
                for (int j = 0; j < array5.GetLength(1); j++)
                {
                    if (array5[i, j] < minVal)
                        minVal = array5[i, j];

                    if (array5[i, j] > maxVal)
                        maxVal = array5[i, j];
                }
            }

            Console.WriteLine("Задание 5:");
            Console.WriteLine("Минимальное значение: " + minVal);
            Console.WriteLine("Максимальное значение: " + maxVal);
            Console.WriteLine();

            Console.WriteLine("Задание 6:");
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();
            int wordCount = sentence.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine("Количество слов: " + wordCount);
            Console.WriteLine();

            Console.WriteLine("Задание 7:");
            Console.WriteLine("Введите предложение:");
            sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ReverseString(words[i]);
            }

            string reversedSentence = string.Join(" ", words);
            Console.WriteLine("После переворота: " + reversedSentence);
            Console.WriteLine();


            Console.WriteLine("Задание 8:");
            Console.WriteLine("Введите предложение:");
            sentence = Console.ReadLine();
            int vowelCount = CountVowels(sentence);
            Console.WriteLine("Количество гласных букв: " + vowelCount);
            Console.WriteLine();

            Console.WriteLine("Задание 9:");
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Console.WriteLine("Введите подстроку для поиска:");
            string substring = Console.ReadLine();
            int occurrenceCount = CountSubstringOccurrences(str, substring);
            Console.WriteLine("Результат поиска: " + occurrenceCount);
            Console.WriteLine();

            Console.ReadKey();
        

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static int CountVowels(string str)
        {
            string vowels = "aeiouAEIOU";
            int count = 0;
            foreach (char c in str)
            {
                if (vowels.Contains(c))
                    count++;
            }
            return count;
        }

        static int CountSubstringOccurrences(string str, string substring)
        {
            int count = 0;
            int index = 0;

            while ((index = str.IndexOf(substring, index, StringComparison.Ordinal)) != -1)
            {
                index += substring.Length;
                count++;
            }

            return count;
        */

        Console.ReadKey();
        }
    }
}
