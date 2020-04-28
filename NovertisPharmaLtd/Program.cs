using System;

namespace NovertisPharmaLtd
{
    class Program
    {
        static void Main(string[] args)
        {
            Date manufacDate = new Date(05,06,2019);
            Date expDate = new Date(05,06,2020);
            Medicine medicine = new Medicine("54re", "Atesunate", "Chemiron", 2314, 300, 45, manufacDate, expDate);
            Medicine medicine2 = new Medicine("54re", "Atesunate", "Chemiron", 2314, 300, 0, manufacDate, expDate);
            Sales sales = new Sales("54de", "Lagos", 35, 4500, 3000);
            

            Console.WriteLine(medicine.Print());
            Console.WriteLine(sales.Display(5000,4000));
            Console.WriteLine(sales.Display());
            Console.WriteLine(medicine.Print(manufacDate,expDate));
            Console.WriteLine(medicine2.ZeroStock());
        }
    }
}
