using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.вывести в столбик 10 раз слово "Привет";
            //int count = 1;
            //while(count<=10)
            //{
            //    Console.WriteLine("Привет");
            //    count++;
            //}
            //Console.ReadLine();

            //do
            //{
            //    Console.WriteLine("Привет");
            //    count+=1;
            //}
            //while (count<=10);
            //Console.ReadLine();

            //for(int count=1;count<=10;count++)
            //{
            //    Console.WriteLine("Привет");
            //}
            //Console.ReadLine();


            //2.вывести в столбик первые 10 натуральных чисел;
            //int count = 0;
            //while(count<10)
            //{
            //    count++;
            //        Console.WriteLine($"{count}");
            //}
            //Console.ReadLine();


            //do
            //{
            // count ++;
            //    Console.WriteLine($"{count}");
            //}
            //while (count < 10);
            //Console.ReadLine();


            //for (int count=1;count<=10;count++)
            //{
            //    Console.WriteLine($"{count}");
            //}
            //Console.ReadLine();


            //3.вывести в столбик первые 5 натуральных чисел в обратном порядке;
            //int count = 6;
            //while (count>1)
            //{
            //    count--;
            //    Console.WriteLine($"{count}");
            //}
            //Console.ReadLine();

            //do
            //{
            //    count--;
            //    Console.WriteLine($"{count}");
            //}
            //while (count>1);
            //Console.ReadLine();

            //for (int count=5;count>0;count--)
            //{
            //    Console.WriteLine($"{count}");
            //}
            //Console.ReadLine();


            //4.вывести на экран целые числа из интервала от 1 до n;
            //Console.Write("n= ");
            //int n = int.Parse(Console.ReadLine());
            //int count = 0;
            //while (count<n)
            //{
            //    count++;
            //    Console.WriteLine($"{count}");
            //}
            //Console.ReadLine();


            //do
            //{
            //    count++;
            //    Console.WriteLine($"{count}");
            //}
            //while (count<n);
            //Console.ReadLine();


            //for (int count = 1; count<=n; count++)
            //{
            //    Console.WriteLine($"{count}");
            //}
            //Console.ReadLine();




            //Задача 1.Заполнить одномерный массив из 8 целых чисел с клавиатуры и вывести его на экран.
            //int[] omas = new int[8];
            //Console.WriteLine("Заполнение одномерного массива");
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.Write($"omas[{i}]= ");
            //    omas[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Вывод одномерных массивов");
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine($"omas[{i}]= {omas[i]}");
            //}
            //Console.ReadLine();

            //Задача 2.Составьте программу ввода(без клавиатуры) и вывода массива: 5, -2, 3, -6, 7, 9, -4, 8, 1, 2, 7, -3.
            //int[] omas = new int[12] { 5, -2, 3, -6, 7, 9, -4, 8, 1, 2, 7, -3 };

            //Console.WriteLine("Вывод одномерных массивов");
            //for (int i = 0; i < 12; i++)
            //{
            //    Console.WriteLine($"omas[{i}]= {omas[i]}");
            //}
            //Console.ReadLine();

            //Задача 3.Массив предназначен для хранения значений ростов двенадцати человек.С помощью датчика случайных чисел заполнить массив целыми значениями, лежащими в диапазоне от 163 до 190 включительно.
            //Random random = new Random();
            //int[] omas = new int[12];
            //for(int i=0;i<omas.Length;i++)
            //{
            //    omas[i] = random.Next(163, 190);
            //}
            //Console.WriteLine("Вывод одномерных массивов");
            //for (int i = 0; i < 12; i++)
            //{
            //    Console.WriteLine($"omas[{i}]= {omas[i]}");
            //}
            //Console.ReadLine();


            //Задача 4
            //Random random = new Random();
            //int[] omas = new int[31];
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    omas[i] = random.Next(5, 20);
            //}
            //Console.WriteLine("Вывод одномерных массивов");
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.WriteLine($"omas[{i}]= {omas[i]}");
            //}
            //int sum = 0;
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    //sum = sum + omas[i];
            //    sum += omas[i];
            //}
            //Console.WriteLine($"Средняя температура= {sum/omas.Length}");
            //Console.ReadLine();



        }
    }
}
