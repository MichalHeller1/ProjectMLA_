using DALandBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMLA
{
    internal interface ICommand
    {

        public bool Execute(JunkFood j);  
    }
}
