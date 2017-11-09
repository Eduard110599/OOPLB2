using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр6
{
    /*
     *                 [Товар] 
                   /      \        \
               [Цветы] [Продукт]   [Часы]
                           \
                    [Кондит.изделие]    
                        /      \
                   [торт]    [конфеты]
        
       
   */
   enum Gabarit : int {malenkiy,sredniy,bolshoy};
    static class ERROR
    {
        static string msgText = "Ошибка!!!";
        public static void Msg()
        {
            Console.WriteLine(msgText);
        }
    }
    public partial class Tovar//partial class
    {
        public override string ToString()
        {
            return $"{name}: {price}$ x {count}k. ";
        }
    }
    public class Present //класс-контейнер
    {
        Tovar[] happy = new Tovar[0];
        string name;

        public Present(string name)
        {
            this.name = name;
        }
public void Add(Tovar a)
        {
            int len = happy.Length;
                System.Array.Resize(ref happy, len + 1);
            happy[len] = a;
            
        }
        public double allsum;
        public void AllPrice()//общая цена подарка
        { 
            
            foreach (var item in happy)
            {
              
                    allsum += item.price;
               
            }
            Console.WriteLine(allsum);
        }
        public void SravnenieMass()//нахождение элемента с минимальной массой
        {
            Tovar obj=new Tovar();
            foreach (var item in happy)
            {
                foreach (var item2 in happy)
                {
                    if(obj.massa==0 || item.massa<item2.massa)
                    {
                        obj = item;
                    }
                }
            }
            Console.WriteLine(obj);
        }
        public void Print()
        {
            Console.WriteLine("Present "+name+":");
            
            foreach (var item in happy)
            {
                Console.WriteLine("\t"+item+" ");
            }
        }
    }
    public interface ITovar
    {
        void Buy();
        void Add(int addcount);
        void NewPrice(int price);
        void ShowPrice();
    }
    interface ICveti
    {
        void ShowPrice();
    }

    public class Product : Tovar, ITovar
    {
        public int srok;

        public void Buy()
        {
            if (count > 0) --count;
            else ERROR.Msg();
        }
        public void Add(int addcount)
        {
            this.count = +addcount;
        }

        public void NewPrice(int price)
        {
            this.price = price;
        }
        public void ShowPrice()
        {
            Console.WriteLine($"{name} \n Price:  {price}$");
        }

        public override string ToString()
        {
            return $"{name}: {price}$ x {count}k. {(Gabarit)gabar}";
        }
    }


    public class KonditerIzdelie : Product
    {
        public double kkal;
        public override string ToString()
        {
            return $"{name}:{massa}gr. x {price}$ x {count}k. Энергетич ценность:{kkal}";
        }
    }
    public class Konfet : KonditerIzdelie
    {
        public double kkal;
        public Konfet(string name, double massa, double price, int count, double kkal)
        {
            this.name = name;
            this.massa = massa;
            this.price = price;
            this.count = count;
            this.kkal = kkal;
        }
        public override string ToString()
        {
            return $"{name}:{massa}gr. x  {price}$ x {count}k. Энергетич ценность:{kkal}";
        }


    }
    public class Tort : KonditerIzdelie
    {
        public double kkal;
        public Tort(string name, double massa, double price, int count, double kkal,int gabar)
        {
            this.name = name;
            this.massa = massa;
            this.price = price;
            this.count = count;
            this.kkal = kkal;
            this.gabar = gabar;

        }
        public override string ToString()
        {
            return $"Габариты: [{(Gabarit)gabar}]. Имя: {name}:{massa}gr. x  {price}$ x {count}k.\n Энергетич Ценность:{kkal} ккал";
        }

    }
    sealed class Cveti : Tovar, ICveti
    {
        public string svegest;
        public Cveti(string name,double massa, double price, int count, string svegest,int gabar )
        {
            this.name = name;
            this.massa = massa;
            this.price = price;
            this.count = count;
            this.svegest = svegest;
            this.gabar = gabar;
        }
        void ICveti.ShowPrice()
        {
            Console.WriteLine($"{name}: (букет)");
            Console.WriteLine($"Стандартная цена:  {price}");
            Console.WriteLine($"Добавить 2 цветка (7р за 1) :  {price + 14}");
            Console.WriteLine($"Добавить 4 цветка (7р за 1) :  {price + 28}");
        }
        public override string ToString()
        {
            return $"Габариты: [{(Gabarit)gabar}]. Имя: {name}:{massa}gr. x  {price}$ x {count}k. \n Cвежесть:{svegest}";
        }

    }
    public class Watch : Tovar
    {
        string raritet;
        public Watch(string name,double massa, double price, int count, string raritet, int gabar)
        {
            this.name = name;
            this.massa = massa;
            this.price = price;
            this.count = count;
            this.raritet = raritet;
            this.gabar = gabar;
        }
        public override string ToString()
        {
            return $"Габариты: [{(Gabarit)gabar}]. Имя: {name}:{massa}gr. x {price}$ x {count}k. \n Редкость часов:{raritet}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cveti buk1 = new Cveti("Розы",350, 33, 7, "свежие", 1);
            Watch wch1 = new Watch("Rolix",270, 5234, 1, "raritet",0);
            Tort Tr1 = new Tort("Наполеон",1500, 166.80, 1, 5863,1);
            Product kt1 = new Tort("Пирамида",1200, 13.60, 1, 3863,(int)Gabarit.sredniy);
          /*  Console.WriteLine("\n\nВыводим цену цветов с помощью интерфейса ICveti \n\n");
            ((ICveti)buk1).ShowPrice();

            ITovar NewTovar = kt1;
            Console.WriteLine(NewTovar is Tort);
            Console.WriteLine(NewTovar is Tovar);
            Console.WriteLine(NewTovar is Program);

                 Tovar[] stack = new Tovar[4];
               stack[0] = buk1;
               stack[1] = wch1;
               stack[2] = Tr1;
               stack[3] = kt1;
               Console.WriteLine("Содержание стека:");
             foreach (var item in stack)
               {
                   Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
                   Console.WriteLine(item.ToString());
               }*/
            Present NewPresent = new Present("for My Mom!");
            NewPresent.Add(buk1);
            NewPresent.Add(wch1);
            NewPresent.Add(Tr1);
            NewPresent.Print();
            Console.WriteLine();
            Console.WriteLine("Вывод объекта из подарка с наименьшей массой:");
            NewPresent.SravnenieMass();
            Console.WriteLine();
            Console.Write("Общая сумма подарка:");
            NewPresent.AllPrice();
        }
    }
    public partial class Tovar//partial class
    {
        public string name;
        public double price;
        public int count;
        public double massa;
        public int gabar;
    }
}
