using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALandBL.making_drinks
{
    public class Coffee :JunkFood, IUnfinishedProduct
    {
        private static int count = 0;
        private static int amount = 10;
        public Coffee(string _name, double _price) : base(_name, _price)
        {
        }

       public override string Doch()
        {
            return $"{count } coffee ";
        }

        public override bool Shop()
        {
            count++;
            amount--;
            Console.WriteLine("enjoy from your coffee");
            if (amount <5) 
            {
                ToSapak(this);
            }
            return  true;
        }
        public void IsMaking()
        {
            Console.WriteLine($"It takes time to prepare the {Name}, please be patient\r\n");
        }
    }
}
