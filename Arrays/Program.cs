//#define ARRAYS_1
//#define ARRAYS_2
//#define JAGGED_ARRAYS
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if ARRAYS_1
            Console.WriteLine("Arrays");
            Console.Write("Введите размер массива");
            int n = 5;//Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Размер массива: { arr.Length}");
            Console.WriteLine($"Размер массива: { arr.GetLength(0)}");
            Console.WriteLine($"Кодичество измерений: { arr.Rank}");

            Random rand = new Random(0);//генерация случайныъ чисел - класс Random
            //по умолчанию Random генерирует всегда разные числа... (0) - числа не меняются 
            for(int i = 0; i<arr.Length; i++)
            {
                arr[i] = rand.Next(100);//заполнение массива случайными числами
            }

            for(int i =0; i<arr.Length;i++)//вывод массива
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();

            foreach(int i in arr)//вывод массива 
                {
                Console.Write(i + "\t");
                }
            Console.WriteLine();

            int min = arr[0];
            int max = arr[0];
            for(int i=0; i<arr.Length; i++)
            {
                if (min > arr[i])
                    min = arr[i];
                if(max < arr[i])
                    max = arr[i];
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
            int sum = 0;
            for(int i=0; i<arr.Length;i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
            Console.WriteLine((double)sum/arr.Length);

            Console.WriteLine($"sum arr {arr.Sum()}");
            Console.WriteLine($"avr arr {arr.Average()}");
            Console.WriteLine($"min arr {arr.Min()}");
            Console.WriteLine($"max arr {arr.Max()}");
#endif

#if ARRAYS_2
            Console.Write("Введите количество строк");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество строк");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] i_arr_2 = new int[rows, cols];
            Random rand = new Random(0);
            Console.WriteLine($"Размер массива {i_arr_2.Length}");

            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    i_arr_2[i, j] = rand.Next(10);
                }
            }
            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    Console.Write(i_arr_2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"sum arr {i_arr_2.Cast<int>().Sum()}");//преобразование в одном массив
            Console.WriteLine($"min arr {i_arr_2.Cast<int>().Min()}");//преобразование в одном массив
            Console.WriteLine($"sax arr {i_arr_2.Cast<int>().Max()}");//преобразование в одном массив
            Console.WriteLine($"avg arr {i_arr_2.Cast<int>().Average()}");//преобразование в одном массив
#endif

#if JAGGED_ARRAYS

            int[][] arr = new int[][]//объявление зубчастого массива
            {
                new int[] {3,5,8 },
                new int[] {13,21, },
                new int[] {34,55,89 },
                new int[] {144,233 }
            };

            Console.WriteLine($" Jar {arr.Length}");
            for (int i = 0; i<arr.Length;i++)
            {
                for (int j=0;j< arr[i].Length;j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
#endif




        }
    }
}
