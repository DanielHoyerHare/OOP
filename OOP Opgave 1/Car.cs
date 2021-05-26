using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Opgave_1
{
    class Car
    {
        private string licenseplate;
        private string brand;
        private int age;
        private DateTime year;
        public string GetLicense()
        {
            return licenseplate;
        }
        public void SetLicense(string licenseInput)
        {
            licenseplate = licenseInput;
        }

        public string GetBrand()
        {
            return brand;
        }
        public void SetBrand(string brandInput)
        {
            brand = brandInput;
        }
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
        public Car(string licenseInput, string brandInput)
        {
            SetLicense(licenseInput);
            SetBrand(brandInput);
        }
        public Car(string licenseInput, string brandInput, DateTime dateInput)
        {
            SetLicense(licenseInput);
            SetBrand(brandInput);
            SetYear(dateInput);
        }
    }
}
