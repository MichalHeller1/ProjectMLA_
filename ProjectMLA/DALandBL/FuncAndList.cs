using DALandBL.making_drinks;
using DALandBL.Snacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALandBL
{
    public static class FuncAndList
    {
        //לעשות רשימה של כל המחלקות שיש ואז מכל מחלקה שצריך אותה פשוט לקרוא לה
        public static List<JunkFood> FoodList()
        {
            List<JunkFood> junkFoodList = new();
            junkFoodList.Add(new Doritos("Doritos", 4));
            junkFoodList.Add( new Bamba("Bamba", 4));
            junkFoodList.Add( new Beasley("Beasley", 4.5));
            junkFoodList.Add( new Chips("Chips", 4.5));
            junkFoodList.Add( new ChocolateNuts("ChocolateNuts", 5));
            junkFoodList.Add( new Cola("Cola", 5.5));
            junkFoodList.Add( new Exel("Exel", 6));
            junkFoodList.Add( new OrangeJuice("OrangeJuice", 4));
            junkFoodList.Add(new Coffee("Coffee", 6.5));
            junkFoodList.Add(new HatMilk("HatMilk", 6.5));
            junkFoodList.Add(new Sachlav("Sachlav", 7));
            junkFoodList.Add(new Shoko("CoShokola", 6.5));
            return junkFoodList;
        }

        
        //פונקציה לדוח
        //פונקציה לספק
    }
}
