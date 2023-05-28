using DALandBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ProjectMLA
{
    public class Save : ICommand
    {

        public bool Execute(JunkFood j)
        {
            //שרשרת סמיכויות
            IsUnfinishedProduct(j);
            if (j.Shop())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void IsUnfinishedProduct(JunkFood j)
        {
            var isM = j.GetType().GetProperties().ToList().Where(i => i.Name.CompareTo("IsMakeing") == 0).First();
            if (isM != null)
            {
                Form1 form1 = new Form1();
                form1.InMakeing();
            }
        }
    }
}
