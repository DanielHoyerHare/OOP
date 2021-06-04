using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Opgave_1
{
    class Contacts
    {
        private string[] ContaktInfo = System.IO.File.ReadAllLines(@"C:\Users\Tec\Desktop\prog\OOP Opgave 1\OOP Opgave 1\Files\Contacts.txt");
        public string GetContaktInfo(int linjenummer)
        {
            return ContaktInfo[linjenummer];
        }
    }
}
