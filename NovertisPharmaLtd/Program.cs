using System;

namespace NovertisPharmaLtd
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicine medicine = new Medicine("54re", "Atesunate", "Chemiron", 2314, 250, 45, "12/03/2018", "23/11/2019");
            Sales sales = new Sales("54de", "Lagos", 35, 4500, 3000);

           Console.WriteLine(medicine.Print());
            Console.WriteLine(sales.Display(4500,4000));
        }
    }
}
