using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALandBL.Snacks
{
    public class Doritos: JunkFood , IFinishedProduct
    {
        static int countToDoch = 0;
        static int amount = 10;
        public Doritos(string name, double price) : base(name,price)
        {
            
        }
        //דוח
        public override string Doch()
        {
            return $"{countToDoch}, doritus ";
        }
        //פונקצית קניה
        public override bool Shop()
        {
            amount--;
            countToDoch++;
            
            //אם הכמות נהית קטנה מחמש שולחים לספק בקשה למילוי
            if (amount < 5)
            {
                ToSapak(this);
            }
            return true;
        }
    }
}
