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
        private int age;privkekece
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
        public Car(string licenseInput, string brandInput)
        {
            SetLicense(licenseInput);
            SetBrand(brandInput);
        }
        public Car(string licenseInput, string brandInput, DateTime dateInput)
        {
            SetLicense(licenseInput);
            SetBrand(brandInput);
            AgeCounter NewCarAge = new AgeCounter(dateInput);
            SetAge(NewCarAge.GetCarAge(dateInput));
        }
    }
}
