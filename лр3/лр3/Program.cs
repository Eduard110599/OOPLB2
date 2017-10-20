using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр3
{
    public partial class CL
    {
        private int x;
        private int y;
        private double r;
        public static int col;
        private readonly int hash;
        public const string REB = "Ploskost";
        private List<int> stack;


        public int HASH
        {
            get
            {
                return hash;
            }
        }
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (Math.Abs(value) < 100)
                {
                    x = value;
                }
                else
                {
                    Console.WriteLine("ERROR X");
                }
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (Math.Abs(value) < 100)
                {
                    y = value;
                }
                else
                {
                    Console.WriteLine("ERROR Y");
                }
            }
        }
        public double R
        {
            get
            {
                return r;
            }
            set
            {
                if (Math.Abs(value) < 100)
                {
                    r = value;
                }
                else
                {
                    Console.WriteLine("ERROR R");
                }
            }
        }

        static CL()
        {
            col = 0;
        }

        public CL()
        {
            x = 0;
            y = 0;
            r = 1;
            ++col;

        }


        public CL(int a = 0, int b = 0, int c = 1)
        {
            x = a;
            y = b;
            r = c;
            ++col;
        }
        private CL(int a, int b, int c, int d)
        {
            x = a;
            y = b;
            r = Math.Sqrt(Math.Pow(c - a, 2) + Math.Pow(d - b, 2));
            ++col;
        }

        public CL NewCl(int a, int b, int c, int d)
        {
            return new CL(a, b, c, d);
        }



    }

    public partial class CL
    {
        public void DoubleCl(ref CL a)
        {
            a.x = x * 2;
            a.y = y * 2;
            a.r = r * 2;
        }
        public static void Info()
        {
            Console.WriteLine($"{col} object type CL");
        }
        public override string ToString()
        {
            return "Type " + base.ToString() + " x=" + x + " y=" + y + " r=" + r + " Hash=" + GetHashCode();
        }
        public override Boolean Equals(Object obj)
        {
            if (obj == null) return false;
            if (this.GetType() != obj.GetType()) return false;
            if (this.GetHashCode() != obj.GetHashCode()) return false;
            return true;
        }
        public override int GetHashCode()
        {
            return 17 * ((x.GetHashCode()) + (y.GetHashCode()) + (r.GetHashCode()));
        }
        public double S()
        {
            return Math.PI*Math.Pow(r,2);
        }
        public double L()
        {
            return 2 * Math.PI *r;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CL Obj1= new CL(1, 1, 20);
            CL Obj2 = new CL(0, 0,3);
            Console.WriteLine(Obj1.ToString());
            Console.WriteLine(Obj2.ToString());
            Obj2.R = 60;
            Obj1.X = 120;
            Console.WriteLine(Obj1.ToString());
            Console.WriteLine(Obj2.ToString());
            Console.WriteLine("Площади 2-х окружностей:");
            Console.Write($"1-я={Obj1.S()} ");
            Console.WriteLine($"2-я={Obj2.S()}");
            Console.WriteLine("Длины 2-х окружностей:");
            Console.Write($"1-я={Obj1.L()} ");
            Console.WriteLine($"2-я={Obj2.L()}");
            Console.Write("Сравнение строк: ");
            Console.WriteLine(Obj1.Equals(Obj2));
            Console.Write("тип 1-ой окружности: ");
            Console.WriteLine(Obj1.GetType());
            CL[] cls = new CL[5];
            cls[0] = new CL(5, 7, 16);
            cls[1] = new CL(5, 9, 30);
            cls[2] = new CL(13, 16, 16);
            cls[3] = new CL(7, 5, 44);
            cls[4] = new CL(14,14,22);
            Console.WriteLine("Список окружностей:");
            for (int i = 0; i < cls.Length; i++)
            {
                Console.WriteLine($"{i + 1}-я окружность: {cls[i].ToString()}");
            }
            Console.WriteLine("Введите координату:");
            int k= Convert.ToInt32(Console.ReadLine());
            int schet = 0;
            int schet1 = 0;
            Console.WriteLine("Если X=" + k);
            for(int i=0;i<cls.Length;i++)
            {
                if (cls[i].X == k)
                {
                    Console.WriteLine($"Окружность {i + 1} лежит на данной прямой");
                    ++schet;
                }
                
            }
            if (schet == 0)
            {
                Console.WriteLine("Окружность не находится на  координате X");
            }
            Console.WriteLine("Если Y=" + k);
            for (int i = 0; i < cls.Length; i++)
            {
                if (cls[i].Y == k)
                {
                    Console.WriteLine($"Окружность {i+1} лежит на данной прямой");
                    ++schet1;
                }
                
            }
            if (schet1 == 0)
            {
                Console.WriteLine("Окружность не находится на  координате Y");
            }
            Console.WriteLine();
            Console.WriteLine("Вывод окружностей с наим. и наиб. площадью:");
            double[] a = new double[5];
             a[0] = cls[0].S();
            double min = a[0];
            double max = a[0];
            for (int i=1;i<cls.Length;i++)
            {
                a[i] = cls[i].S();
                if(a[i]<min)
                {
                    min = a[i];
                }
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine($"Максимальная площадь:{max},Минимальная площадь:{min}\n");
            // анонимный тип на основе Stack
            var anonStack = new { array = new List<int>() { 8, 1, 6, 3, 7 } };
            for (int i = (anonStack.array.Count - 1); i >= 0; --i)
            {
                Console.Write($"{anonStack.array[i]} ");
            }
            Console.WriteLine();
        }
    }
}