using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Opgave_1
{
    struct AgeCounter
    {
        private int? carAge;

        public AgeCounter(DateTime dateInput): this()
        {
            carAge = GetCarAge(dateInput);
        }

        public int GetCarAge(DateTime dateInput)
        {
            return DateTime.Now.Year - dateInput.Year; ;
        }
    }
}
