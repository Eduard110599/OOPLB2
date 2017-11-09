using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр5
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
    static class ERROR
    {
        static string msgText = "Ошибка!!!";
        public static void Msg()
        {
            Console.WriteLine(msgText);
        }
    }
    public partial  class Tovar
    {
        
        public override string ToString()
        {
            return $"{name}: {price}$ x {count}k.";
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
         
    public class Product:Tovar, ITovar
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
            return $"{name}: {price}$ x {count}k.";
        }
    }


    public class KonditerIzdelie: Product
    {
        public double kkal;
        public override string ToString()
        {
            return $"{name}: {price}$ x {count}k. Энергетич ценность:{kkal}";
        }
    }
    public  class Konfet: KonditerIzdelie
    {
        public double kkal;
        public Konfet(string name, double price, int count, double kkal)
        {
            this.name = name;
            this.price = price;
            this.count = count;
            this.kkal = kkal;
        }
        public override string ToString()
        {
            return $"{name}: {price}$ x {count}k. Энергетич ценность:{kkal}";
        }
      
       
    }
    public  class Tort: KonditerIzdelie
    {
        public double kkal;
        public Tort(string name, double price, int count, double kkal)
        {
            this.name = name;
            this.price = price;
            this.count = count;
            this.kkal = kkal;
        }
        public override string ToString()
        {
            return $"{name}: {price}$ x {count}k. Энергетич Ценность:{kkal} ккал";
        }

    }
    sealed  class Cveti: Tovar, ICveti
    {
        public string svegest;
        public Cveti(string name, double price, int count, string svegest )
        {
            this.name = name;
            this.price = price;
            this.count = count;
            this.svegest = svegest;
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
            return $"{name}: {price}$ x {count}k. \n Cвежесть:{svegest}";
        }

    }
    public  class Watch : Tovar
    {
        string raritet;
        public Watch(string name, double price, int count, string raritet)
        {
            this.name = name;
            this.price = price;
            this.count = count;
            this.raritet = raritet;
        }
        public override string ToString()
        {
            return $"{name}: {price}$ x {count}k. \n Редкость часов:{raritet}";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Cveti buk1 = new Cveti("Розы",33,7,"свежие");
           Watch wch1 = new Watch("Polix", 5234, 1,"raritet");
            Tort Tr1 = new Tort("Наполеон", 166.80, 2, 5863);
            Product kt1 = new Tort("Пирамида", 13.60, 3, 3863);
            Console.WriteLine("\n\nВыводим цену цветов с помощью интерфейса ICveti \n\n");
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
            }
        }
    }
    public partial class Tovar
    {
        public string name;
        public double price;
        public int count;
    }
}
