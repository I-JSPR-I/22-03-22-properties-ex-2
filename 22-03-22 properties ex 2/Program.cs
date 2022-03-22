using System;

namespace _22_03_22_properties_ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage opslag = new Storage();
            opslag.Teller = 2;
            opslag.Noemer = 3;
            Console.WriteLine(opslag.Teller);
            Console.WriteLine(opslag.Noemer);
            Console.WriteLine(opslag.Breuk);
        }
    }
}
