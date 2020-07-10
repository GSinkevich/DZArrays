using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        /// <summary>
        /// Найти минимальный элемент массива
        /// </summary>
        /// 
        static void Main(string [] args)
        {
            var a = Task7();
         //   Console.WriteLine(a);

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
        public static int  Task1()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            return a.Min();
            
            
        }

        /// <summary>
        /// Найти два наибольших элемента массива
        /// </summary>  
        public static int[] Task2()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int b = a.Max();
            a = a.Where(val => val != b).ToArray();

            int g = a.Max();

            return new int[] { b, g };
        }

        /// <summary>
        /// Посчитать сумму элементов массива
        /// </summary>
        public static int Task3()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            var result = a.Sum();
            return result;
            //int sum = 0;
            //foreach(var item in a)
            //{
            //    sum = sum + item;
            //}
            //return sum;
        }

        /// <summary>
        /// Заполнить массив по возрастанию от 1 до 100
        /// </summary>
        public static int[] Task4()
        {
            int[] a = new int[100] ;

            for (int i = 0; i < 100; i++)
            {
                a[i] = i+1;
            }

            return a;
        }
        

        /// <summary>
        /// Создать и заполнить массив случайными целыми числами
        /// </summary>
        public static int[] Task5()
        {
            int[] a = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                a[i] = rnd.Next(1, 10);
            }

            return a;

            //пример вызова генератора случайных чисел, он понадобится в данной задаче
            //Random rnd = new Random();
            //int r = rnd.Next(1, 10);//случайное число от 1 до 10
        }

        /// <summary>
        /// Проверить, что в массиве нет одинаковых чисел
        /// </summary>
        public static int Task6()
        {
            int[] a = new int[] { 5,12,15,16,2,15,17,17,213,22};

            for (int i = 0; i < a.Length; i++)

                for (int j = i+1; j < a.Length-1; j++)

                   if (a[i] == a[j])
                    {
                        return 12;
                    }
                    
            return 0;
        }

        /// <summary>
        /// Переставить элементы массива в обратном порядке используя вспомогательный массив
        /// </summary>
        public static int[] Task7()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            
            int[] b = new int[a.Length];
          
                for (int i = 0; i < a.Length; i++)
                {
                    b[a.Length-1-i] = a[i];
                }
            
            return b;
 
        }

        /// <summary>
        /// Переставить элементы массива в обратном порядке НЕ используя вспомогательный массив
        /// </summary>
        public static void Task8()
        {
          
        }

        /// <summary>
        /// Подсчитать сумму чисел в двухмерном массиве
        /// </summary>
        public static void Task9()
        {
            int[,] m = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
        }

        /// <summary>
        /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 9 и вывести на экран консоли
        /// </summary>
        public static void Task10()
        {
        }

        /// <summary>
        /// Двумерный массив скопировать в одномерный
        /// </summary>
        public static void Task11()
        {
            int[,] m = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
        }


        /// <summary>
        /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 99 и определить количество четных чисел в массиве
        /// </summary>
        public static void Task12()
        {
            //подсказка: для определения остатка от деления используется оператор %
            //int ostatok = 4 % 2; //будет равен нулю
        }
    }
}
