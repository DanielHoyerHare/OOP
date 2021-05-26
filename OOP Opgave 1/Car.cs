using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Opgave_1
{
    class Car: MotorVehicle
    {
        private string licenseplate;
        private string brand;
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
