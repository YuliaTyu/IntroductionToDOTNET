//#define STRING_OPERATION
#define DATA_TYPES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if STRING_OPERATION
            //Console.WriteLine("\t\tHello .NET\n");
            //Console.WriteLine("Привет");
            Console.Write("Введите ваше имя");
            string first_name = Console.ReadLine();
            Console.Write("Введите вашу фамилию");
            string last_name = Console.ReadLine();

            Console.Write("Введите ваш возраст");
            int age = Convert.ToInt32(Console.ReadLine());//Load int - 32 бита

            Console.WriteLine(first_name + " " + last_name + " " + age + " ");//конкатенация строк
            Console.WriteLine(String.Format("{0} {1} {2}", first_name, last_name, age));//форматирование строк
            Console.WriteLine($"{first_name} {last_name} {age}");//интерполяция строк  
#endif

#if DATA_TYPES
            Console.WriteLine(sizeof(bool));//вывод размера типа в консоль
            //Console.WriteLine(Boolean.);//класс обвертка
            //варианты объявления
            bool var1;// спецификатор типа
            Boolean var2;//класс- обвертка
            Console.WriteLine(sizeof(char));


            short var = 0;
            Console.WriteLine($"{var.GetType()} занимает {sizeof(short)} Байт и диапозон:{short.MinValue}.....{short.MaxValue}");

           
            
#endif



        }
    }
}
