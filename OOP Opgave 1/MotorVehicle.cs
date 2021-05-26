using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Opgave_1
{
    abstract class MotorVehicle
    {
        record OwnerContactInfo(string name, string telNo);
        private string color;
        private string motorsize;
        private int age;
        private DateTime year;
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int ageInput)
        {
            age = ageInput;
        }
        public void SetYear(DateTime yearInput)
        {
            year = yearInput;
            AgeCounter NewCarAge = new AgeCounter(year);
            SetAge(NewCarAge.GetCarAge(year));
        }
        public string GetYear()
        {
            return year.ToString("dd/MM/yyyy");
        }
        public abstract void SetOwnerInfo(string name, string telNo);
    }
}
