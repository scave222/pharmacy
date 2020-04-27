using System;

namespace NovertisPharmaLtd
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicine medicine = new Medicine("54re", "Atesunate", "Chemiron", 2314, 250, 45, 2000, 2001);
            Sales sales = new Sales("54de", "Lagos", 35, 4500, 3000);
        }
    }
}
