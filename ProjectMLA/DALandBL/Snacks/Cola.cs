﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALandBL.Snacks
{
    public class Cola : JunkFood, IFinishedProduct
    {
        static int countToDoch = 0;
        static int amount = 10;
        public Cola(string name, double price) : base(name, price)
        {

        }
        //דוח
        public override string Doch()
        {
            return $"{countToDoch}, Cola ";
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
