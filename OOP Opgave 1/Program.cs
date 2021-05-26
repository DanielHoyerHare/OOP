using System;

namespace OOP_Opgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car NewCar = new Car("AC83712", "Fiat");
            Console.WriteLine(NewCar.GetLicense() + ", " + NewCar.GetBrand());
            Car NewCar2 = new Car("GE97374", "Lamborghini", new DateTime(2009,11,10));
            Console.WriteLine(NewCar2.GetLicense() + ", " + NewCar2.GetBrand() + ", " + NewCar2.GetAge());
            Console.ReadKey();
        }
    }
}
