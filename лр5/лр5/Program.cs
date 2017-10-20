using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр5
{
    public abstract class Tovar
    {
        public abstract string name();
        public abstract int kolichestvo();
        public abstract double cena();
    }
    interface ITovar
    {

    }
    public class Product:Tovar
    {
       
        public string tyjpe()
        {
            return "type of product";
        }

    }
    
    
    public abstract class KonditerIzdelie
    {
     
    }
    public  class Konfet: KonditerIzdelie
    {
        public  double kkal()
        {
            return 0;
        }
    }
    public  class Tort: KonditerIzdelie
    {
        public  double kkal()
        {
            return 0;
        }
    }
    public  class Cveti: Tovar
    {

    }
    public  class Watch : Tovar
    {

    }
    
    class Program
    {public abstract class Pechenie
    {

    }
        static void Main(string[] args)
        {
       
        }
    }
}
