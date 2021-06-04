using System;

namespace OOP_Opgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacts Info = new Contacts();
            Console.WriteLine(Info.GetContaktInfo(0));
        }
    }
}
