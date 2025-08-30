//#define STRING_OPERATION
//#define DATA_TYPES
//#define FACTORIAL
//#define CALC
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET // пространство имен
{
    internal class Program//неявный класс
    {
        static void Main(string[] args)//вызывается для класса//принимаются параметры консольной строки
        {
#if STRING_OPERATION
            //Console.WriteLine("\t\tHello .NET\n");
            //Console.WriteLine("Привет");
            Console.Write("Введите ваше имя");
            string first_name = Console.ReadLine();
            Console.Write("Введите вашу фамилию");
            string last_name = Console.ReadLine();
            Console.Write("Введите ваш возраст");
            int age = Convert.ToInt32(Console.ReadLine());//Load int - 32 бита//преобразования типов

            Console.WriteLine(first_name + " " + last_name + " " + age + " ");//конкатенация строк
            Console.WriteLine(String.Format("{0} {1} {2}", first_name, last_name, age));//форматирование строк
            Console.WriteLine($"{first_name} {last_name} {age}");//интерполяция строк  
#endif

#if DATA_TYPES
            //Console.WriteLine(sizeof(bool));//вывод размера типа в консоль
            //Console.WriteLine(Boolean.);//класс обвертка
            //варианты объявления
            //bool var1;// спецификатор типа
            //Boolean var2;//класс- обвертка
            //Console.WriteLine(sizeof(char));


            short var = 0;
            Console.WriteLine($"{var.GetType()} занимает {sizeof(short)} Байт и диапозон:{short.MinValue}.....{short.MaxValue}");

            byte var_1 = 0;
            Console.WriteLine($"{var_1.GetType()} занимает {sizeof(byte)} Байт и диапозон:{byte.MinValue}.....{byte.MaxValue}");
           
            int var_2 = 0;
            Console.WriteLine($"{var_2.GetType()} занимает {sizeof(int)} Байт и диапозон:{int.MinValue}......{int.MaxValue}");

            long var_3 = 0;
            Console.WriteLine($"{var_3.GetType()} занимает {sizeof(long)} Байт и диапозон:{long.MinValue}.....{long.MaxValue}");

            float var_4 = 0;
            Console.WriteLine($"{var_4.GetType()} занимает {sizeof(float)} Байт и диапозон:{float.MinValue}.....{float.MaxValue}");

            double var_5 = 0;
            Console.WriteLine($"{var_5.GetType()} занимает {sizeof(double)} Байт и диапозон:{double.MinValue}....{double.MaxValue}");
            
            decimal var_6 = 0;
            Console.WriteLine($"{var_6.GetType()} занимает {sizeof(decimal)} Байт и занимает:{decimal.MinValue}...{decimal.MaxValue}");


            Console.WriteLine(sizeof(byte));//вывод размера типа в консоль
            Byte var_77;                    //класс- обвертка

            Console.WriteLine(sizeof(short));
            Int16 var_88;

            Console.WriteLine(sizeof(int));
            Int32 var_99;

            Console.WriteLine(sizeof(long));
            Int64 var_100;
            
            Console.WriteLine(sizeof(float));
            Single var_200;

            Console.WriteLine(sizeof(double));
            Double var_300;

            Console.WriteLine(sizeof(decimal));
            Decimal var_400;

            Console.WriteLine($"Decimal занимает {sizeof(decimal)} байт");


#endif


#if FACTORIAL

            long Factorial(int n)//метод для объекта n
            {
                if (n == 1) return 1; //РАВНО ЛИ ЧИСЛО ЕДИНИЦЕ

                return n * Factorial(n - 1); //ЧИСЛО НЕ РАВНО ЕДИНИЦЕ - ВЫПОЛНЯЕТСЯ КОД поэтапно (5*4*3*2*1) вернув 1 
            }

           long factorial2 = Factorial(2);  // 2
           long factorial5 = Factorial(5);  // 120
           long factorial10 = Factorial(10);  // 3628800
           long factorial42 = Factorial(42);  // много

            
           Console.WriteLine($"Факториал числа 2 = {factorial2}");
           Console.WriteLine($"Факториал числа 5 = {factorial5}");
           Console.WriteLine($"Факториал числа 10 = {factorial10}");
           Console.WriteLine($"Факториал числа 42 = {factorial42}");


            Console.WriteLine($"factorial 5 = {5 * 4 * 3 * 2 * 1}"); //)))))))))))))))))


#endif

#if CALC




#endif


        }
    }
}
