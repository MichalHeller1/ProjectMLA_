using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALandBL.Snacks
{
    public class ChocolateNuts :JunkFood, IFinishedProduct
    {
        static int countToDoch = 0;
        static int amount = 10;
        public ChocolateNuts(string name, double price) : base(name, price)
        {

        }
        /*//מוריד מהכמות שיש
        public static void Amount()
        {
            amount--;
        }
        //מעלה לכמות שיש
        public static void CountToDoch()
        {
            countToDoch++;
        }
        //מאפס את הכמות שיש לאחר שהספק מכניס עוד
        public static void ClearAmount()
        {
            amount=10;
        }
        //מאפס את הכמות שהזמינו כל סוף יום
        public static void ClearCountToDoch()
        {
            countToDoch=0;
        }*/
        //דוח
        public override string Doch()
        {
            return $"{countToDoch}, Chocolate nuts ";
        }
        //פונקצית קניה
        public override void Shop()
        {
            amount--;
            countToDoch++;
            Console.WriteLine("הקניה בוצעה בהצלחה!!");
            //אם הכמות נהית קטנה מחמש שולחים לספק בקשה למילוי
            if (amount < 5)
            {
                ToSapak(this);
            }
        }
    }
}
