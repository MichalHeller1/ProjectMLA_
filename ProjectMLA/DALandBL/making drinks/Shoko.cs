using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALandBL.making_drinks
{
    public class Shoko : JunkFood, IUnfinishedProduct
    {
        static int amount = 10;
        static int countToDoch = 0;
        public Shoko(string _name, double _price) : base(_name, _price)
        {

        }
        //דוח
        public override string Doch()
        {
            return $"{countToDoch}, Shoko ";
        }

        //פונקצית קניה
        public override void Shop()
        {
            amount--;
            countToDoch++;
            Console.WriteLine("enjoy from your shoko");
            //אם הכמות נהית קטנה מחמש שולחים לספק בקשה למילוי
            if (amount < 5)
            {
                ToSapak(this);
            }
        }
        //פונקצית הכנה
        public void IsMaking()
        {
            Console.WriteLine($"It takes time to prepare the {Name}, please be patient\r\n");
        }

    }
}
