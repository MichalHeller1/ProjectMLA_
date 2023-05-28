using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALandBL
{
    public class JunkFood
    {
        public JunkFood(string _name,double _price)
        {
            Name = _name;
            Price = _price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        

        public virtual string Doch()
        {
            return " ";
        }
        public static void ToSapak(JunkFood j)
        {
            Console.WriteLine($"ספק יקר תכניס בבקשה עוד {j.Name}");
        }
        public virtual bool Shop() 
        {
            return false;
        }
    }
}
