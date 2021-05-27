using System;
using System.Linq;
using System.Collections.Generic;

namespace OOP_Opgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();

            carList.Add(new Car("GE97374", "Lamborghini", new DateTime(2009, 11, 10), new DateTime(2019, 4, 24)));
            carList.Add(new Car("FA74492", "Audi", new DateTime(2002, 5, 27), new DateTime(2020, 7, 12)));
            carList.Add(new Car("PO36194", "Fiat", new DateTime(2012, 1, 7), new DateTime(2018, 3, 16)));

            Car results = carList.First(s => s.GetBrand() == "Audi");
            Console.WriteLine(results.GetLicense() + " (" + results.GetBrand() +")");
            Console.ReadKey();
        }
        public void ExeceptionMessage(Exception e) => Console.WriteLine(e.Message);
    }
}
