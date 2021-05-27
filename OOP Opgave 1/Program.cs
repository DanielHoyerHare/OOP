using System;

namespace OOP_Opgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car NewCar = new Car("GE97374", "Lamborghini", new DateTime(2009,11,10), new DateTime(2019,4,24));
            Console.WriteLine(NewCar.GetLicense() + ", " + NewCar.GetBrand() + ", " + NewCar.GetYear() + ", " + NewCar.GetAge());
            Console.ReadKey();
        }
        public void ExeceptionMessage(Exception e) => Console.WriteLine(e.Message);
    }
}
