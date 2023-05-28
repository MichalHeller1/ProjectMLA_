using DALandBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectMLA
{
    
    public class Meditor
    {
        const string FILENAME = "..\\Doch.txt";
        List<JunkFood> listOfFood = FuncAndList.FoodList();
        string s = " ";

        //פונקציה שמקבלת את הדוח מכל מחלקה מסכמת את כולם ומכניסה אל תוך קובץ טקסט (עם בעיות אם קיים או לא)
        public void DochToText()
        {
            listOfFood.ToList().ForEach(item => { s += $"{item.Doch()} \n"; });
            if (File.Exists(FILENAME))
            {
                Console.WriteLine("the fille is here");
                File.WriteAllText(FILENAME, s);
            }
            else
            {
                Console.WriteLine("the file is not here");
                StreamWriter writer = new StreamWriter(FILENAME);
                writer.WriteLine(s);
                writer.Close();
            }
            StreamReader reader = new StreamReader(FILENAME);
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
