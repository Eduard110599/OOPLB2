using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Inicialization()
        {
            sbyte sb = 8;
            short sh = 16;
            int i = 32;
            long lg = 64;
            byte bt = 8;
            ushort ush = 16;
            uint ui = 32;
            ulong ugl = 64;
            char cr = 'e';
            bool bl = false;
            float fl = 32;
            double de = 6.4;
            decimal dm = 128;
            string stg = "privet";
            object ot = "object";
        }
        static void operation()
        {
            //5 неявных
            short a = 32;
            int b = a;//1
            double c = a;//2

            char prd = '3';
            int s = prd;//3

            byte btr = 4;
            long bbb = btr;//4

            float fle = 24.4f;
            double dole = fle;//5

            //5 явных 
            short brr = 13;
            int bbbb = (int)brr;//1
            double dd = (double)bbbb;//2

            char cc = '2';
            float ff = (float)cc;//3

            byte ttt = 45;
            long lll = (long)ttt;//4

            float flf = 234.11f;
            double aaa = (double)flf;//5

            //упаковка и распаковка

            int r = 45;
            Object x = r;//упаковка
            float rt = (float)(int)x;//распаковка, затем приведение типаZZZ

            // неявно типизированная переменная       
            var vr = "earch";
            string clearvar = vr;
            //nullable
            int? nullable = null;
        }
        static void sstring()
        {
            string str1 = "привет друг";
            string str2 = "BSTU";
            string[] str4 = { "Privet drug", "Vse super" };
            string str3;
            Console.WriteLine("Вывод строки на экран");
            if (String.Compare(str1, str2) > 0)
            {
                Console.WriteLine(str1);
            }
            else if (String.Compare(str1, str2) < 0)
            {
                Console.WriteLine(str2);
            }
            else if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine("одинаковые позиции");
            }
            Console.WriteLine('\n');
            str3 = String.Concat(str1, str2);//сцепление через Concat
            Console.WriteLine("Сцепление через Concat: {0}", str3);
            String str5 = String.Join(".", str4);
            Console.WriteLine("Соединение через Join: {0}", str5);
            Console.WriteLine("Copy");
            Console.WriteLine("До копирования: {0}", str2);
            string prom = str2;
            str2 = String.Copy(str1);
            Console.WriteLine("После копирования: {0}", str2);
            Console.WriteLine('\n');
            str2 = prom;

            //Выделение подстроки через SubString
            int firstsymbol = 7;
            int length = 4;
            String substr = str1.Substring(firstsymbol, length);
            Console.WriteLine("Выделение подстроки через Substring: {0}", substr);
            Console.WriteLine('\n');
            
            // Разделение строки на слова через Split
            Char separator = ' ';
            String[] razdel = str1.Split(separator);
            Console.WriteLine("Разделение строки на слова через Split");
            foreach (var word in razdel)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine('\n');
            Console.WriteLine("Вставка строки с пом. Insert в строку:{0} ",str1);
            String newstr = str1.Insert(7, ".Я твой");
            Console.WriteLine("Измененная строка: {0}", newstr);
            Console.WriteLine('\n');

            //удаление заданной подстроки
            Console.WriteLine("началоная строка: {0}", str2);
            Console.WriteLine(str2.Remove(2, 2));
            Console.WriteLine('\n');

            //Работа с пустой и null строками
            Console.WriteLine("Работа с пустой и null строками");
            String nullstr = null;
            String emptystr = "";
            Console.WriteLine(str1 + nullstr);
            Console.WriteLine(str1 + emptystr);
            str1 = String.Copy(emptystr);
            // str2 = String.Copy(nullstr); выдаст ошибку
            Console.WriteLine(str1);
            Console.WriteLine('\n');

            // Работа со строкой с помощью String.Builder
            StringBuilder str6 = new StringBuilder("Builder's String");
            Console.WriteLine(str6);
            Console.WriteLine(str6.Remove(9, 7));
            Console.WriteLine(str6.Append(" new String"));
            Console.WriteLine(str6.Insert(0, "My "));
            Console.WriteLine();
        }
        static void STR()
        {
            //двумерный массив (матрица)
            int[][] mass = new int[3][];
            mass[0] = new int[3] { 3, 9, 6 };
            mass[1] = new int[3] { 1, 4, 7 };
            mass[2] = new int[3] { 2, 5, 8 };
            for(int i=0;i<mass.Length;i++)
            {
                for (int j = 0; j < mass[i].Length; j++)
                {
                    Console.Write($"{mass[i][j]} \t");
                }
                Console.WriteLine();
            }
            //Массив строк
            string[] massstr = new string[] { "Сегодня", "замечательный", "день" };
            for(int i=0;i<massstr.Length;i++)
            {
                Console.Write(massstr[i]);
                Console.Write(" ");
                /* или можно сделать вывод с пом Join
             Console.WriteLine(" ",massstr);
             */
            }
            Console.WriteLine();
            Console.WriteLine("длина массива строк: {0}", massstr.Length);
            int position = 1;
            string newstring = "просто";
            for (int i = 0; i < massstr.Length; i++)
            {
                if (i == position)
                {
                    massstr[i] = newstring;
                }
            }
            Console.WriteLine(String.Join(" ", massstr));
            Console.WriteLine();

            //ступенчатый массив
            Console.WriteLine("Вывод ступенчатого массива\n");
            int[][] lest = new int[3][];
            lest[0] = new int[2];
            lest[1] = new int[3];
            lest[2] = new int[4];
            for(int i=0;i<lest.Length;i++)
            {
                for(int j=0;j<lest[i].Length;j++)
                {
                    lest[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int n = 0; n < lest.Length; n++)
            {
                for (int m = 0; m < lest[n].Length; m++)
                {
                    Console.Write($"{lest[n][m]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //неявно типиз. переменые
            Console.WriteLine("Неявно типизированные переменные с массивом и строкой");
            var neyavmass = new[] { 1, 11, 13 };
            var neyavstr = "неявно типизированная строка";
        }
        static void Corteg()
        {
            Console.WriteLine("\nРабота с кортежами");
            (int, string, char, string, ulong) cort = (int1: 33, string1: "privet", char1: 'R', string2: "Like", ulong1: 232);
            Console.Write(cort.Item1);
            Console.Write("|");
            Console.Write(cort.Item2);
            Console.Write("|");
            Console.Write(cort.Item3);
            Console.Write("|");
            Console.Write(cort.Item4);
            Console.Write("|");
            Console.Write(cort.Item5);
            Console.WriteLine();
            int elem1 = cort.Item1;
            string elem2 = cort.Item2;
            char elem3 = cort.Item3;
            string elem4 = cort.Item4;
            ulong elem5 = cort.Item5;
            (int, string, char, string, ulong) cort2 = (int1: 46, string1: "Vosdayanie",
                char1: 'X', string2: "Numarovanie", ulong1: 336);
            Console.WriteLine(cort.Equals(cort2));
        }
            static void Main(string[] args)
            {
                (int, int, int, char) GetTuple(int[] array, string sentense)
                {
                    int min = array[0];
                    int max = array[0];
                    int sum = 0;
                    char letter = sentense[0];
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] > min)
                        {
                            max = array[i];
                        }
                        if (array[i] < min)
                        {
                            min = array[i];
                        }
                        sum += array[i];
                    }
                    var tuple = (max, min, sum, letter);
                    return tuple;
                }
            Inicialization();
            operation();
                sstring();
                STR();
                Corteg();
                int[] numbers = new int[] { 146, 22, 30, 8 };
                var mainTuple = GetTuple(numbers, "Thank you");
                Console.WriteLine("\nПолучение кортежа значений\n");
                Console.WriteLine("Max: {0}", mainTuple.Item1);
                Console.WriteLine("Min: {0}", mainTuple.Item2);
                Console.WriteLine("Sum: {0}", mainTuple.Item3);
                Console.WriteLine("Letter: {0}", mainTuple.Item4);
                Console.ReadLine();
            }
        }
    }
