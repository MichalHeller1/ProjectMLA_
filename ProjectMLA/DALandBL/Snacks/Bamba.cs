using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALandBL.Snacks
{
    public class Bamba :JunkFood, IFinishedProduct
    {
        static int amount = 10;
        static int countToDoch = 0;

        public Bamba(string name, double price) : base(name, price)
        {

        }
        //דוח
        public override string Doch()
        {
            return $"{countToDoch}, Bamba ";
        }
        //פונקצית קניה
        public override bool Shop()
        {
            amount--;
            countToDoch++;
            Console.WriteLine("הקניה בוצעה בהצלחה!!");
            //אם הכמות נהית קטנה מחמש שולחים לספק בקשה למילוי
            if (amount < 5)
            {
                ToSapak(this);
            }
            return true;
        }
    }
}
