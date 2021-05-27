using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Opgave_1
{
    class Car: MotorVehicle, IVehicleInspectionInfo
    {
        public OwnerContactInfo oci;
        private string licenseplate;
        private string brand;

        public DateTime? LastInspection { get; set; }

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

        public override void SetOwnerInfo(string name, string telNo)
        {
            oci = new OwnerContactInfo(name, telNo);
        }

        public DateTime? NextInspection()
        {
            AgeCounter calculation = new AgeCounter();
            if (calculation.GetCarAge(Convert.ToDateTime(LastInspection)) >= 2)
            {
                return DateTime.Now.AddMonths(3);
            }
            else
            {
                return null;
            }
        }

        public Car(string licenseInput, string brandInput)
        {
            SetLicense(licenseInput);
            SetBrand(brandInput);
        }
        public Car(string licenseInput, string brandInput, DateTime dateInput, DateTime lastInspectInput)
        {
            SetLicense(licenseInput);
            SetBrand(brandInput);
            SetYear(dateInput);
            LastInspection = lastInspectInput;
            try
            {
                DateTime? Inspection = NextInspection();
                if (Inspection != null)
                {
                    throw new Exception($"Dit køretøj indkaldes til syn den {Convert.ToDateTime(Inspection).ToString("dd.MM.yyyy") } (" + brand + ")");
                }
            }
            catch(Exception e)
            {
                Program Message = new Program();
                Message.ExeceptionMessage(e);
            }
        }

    }
}
