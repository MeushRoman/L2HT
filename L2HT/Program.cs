using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2HT
{
    class Program
    {
        static void Main(string[] args)
        {
            task7();
           // Console.WriteLine(task2());
        }

        //1.	Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка.
        //      Программа должна сосчитать количество введенных пользователем пробелов. 
        static void task1()
        {
            char i;
            int count = 0;
            do
            {
                i = Console.ReadKey().KeyChar;
                if (i == ' ')
                    count++;
            }
            while (i != '.');

            Console.WriteLine("Пробелов = " + count);
        }

        //5.	Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. 
        //      Например, если было введено число 345, то программа должна вывести число 543.
        static int task2(int num = 234)
        { 
            for (int result = 0; ; result = result * 10 + num % 10, num /= 10) if (num == 0) return result;
        }

        //6.	Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
        static void task3()
        {
            int a = 4, b = 5, c = 6;
            Console.WriteLine("{0}  {1}  {2}", a,b,c);
        }

        //7.	Вывести на экран числа 5, 10 и 21 одно под другим.
        static void task4()
        {
            Console.WriteLine("5\n10\n21\n");
        }

        //8.	Дано расстояние в сантиметрах. Найти число полных метров в нем.
        static void task5(int sm)
        {
            Console.WriteLine("в {0} см, {1} м", sm, sm/100);
        }

        //9.	С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
        static void task6(int days = 234)
        {
            Console.WriteLine("Прошло {0} недель", days/7);
        }
        //4.	Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно

        static void task7(int i = 3, int b = 7)
        {
            for (; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
