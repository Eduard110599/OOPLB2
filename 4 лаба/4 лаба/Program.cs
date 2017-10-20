using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_лаба
{
    public static class Uporyad
    {
        public static bool proverka(this int[] mass)
        {
            bool pr=false;
            //проверка упорядоченности по возрастанию
            for(int i=0;i<mass.Length-1;i++)
            {
                if( mass[i]<mass[i+1])
                { pr = true; }
                else { pr = false; break; }
            }
            return pr;
        }
    }

    public static class Shifr
     {
         
        // метод шифрования
        public static string shr0(this string a, int k)
        {
            string b = "";
            foreach (var item in a)
            {
                
                b =b+Convert.ToChar((Convert.ToInt32(item) + k));
            }
            return b;
        }
     }
    class Program
    {
       
        public class Set
        {
            public string str;
            public int[] mass = new int[0];
            public char symb;
            public int elem;
            public bool proverka;
            //проверка на упорядоченность множества
           
            // перегрузка(+)
            public static Set operator +(Set mnog1, Set mnog2)
            {

                foreach (var item in mnog2.mass)
                {
                    mnog1.Add(item);
                }
                return mnog1;
            }
            public bool Add(int a)
            {
                foreach (var item in mass)
                {
                    if (a == item) return false;
                }
                int l = mass.Length;
                Array.Resize(ref mass, l+1);
                this.mass[l] = a;

                return true;
            }
            public void List()
            {
                foreach (var item in mass)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();

            }
            // перегрузка(++)
            public static Set operator ++(Set set)
            {
                Random a = new Random();
                while(set.Add(a.Next(1, 40))==false);
                return set;
            }
            public static Set operator --(Set set)
            {
                return set;
            }

            //перегрузка <=
            public static bool operator <=(Set mn1, Set mn2)
            {
                if (mn1.mass.Length <= mn2.mass.Length)
                return true;

                return false;
               
            }
            public static bool operator >=(Set mn1, Set mn2)
            {
                return true;
            }
            //перегрузка %
            public static int operator %(Set mnog3, int elem)
            {
                 return mnog3.mass[elem-1];
             
            }
            //перегрузка неявного int
            /*public static implicit operator int(Set mnog4   )
            {
                return mnog4.mass.Length;
              
            }
            /* */
                         public static implicit operator int [](Set m4   )
            {
                return m4.mass;
              
            }             
            
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Шифрование строки");
            string b = "privet, kak laba?";
            string c = b.shr0(2);
            string e = c.shr0(-2);
            Console.WriteLine(c);
            Console.WriteLine(e);
            Console.WriteLine();
            Console.WriteLine("Проверка массива на упорядоченность");
             int[] ms = {1,3,4, 5};
            Console.WriteLine(ms.proverka());
            Set a = new Set();
            Set aa = new Set();
            a.Add(2); a.Add(3); a.Add(1);
            aa.Add(2); aa.Add(5); aa.Add(6);
            Set aaa = a + aa;
            aaa.List();
            aaa++;
            aaa.List();
            Console.WriteLine(aaa<=aa);
            Console.WriteLine(aaa%1);
            Console.WriteLine(aaa%5);

            Console.WriteLine();
            int[]mn = aaa;

            foreach (var item in mn)
            {
                Console.WriteLine(item);
            }
        }
    }
}
