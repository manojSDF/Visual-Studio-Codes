using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number1");
            int no1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Number2");
            int no2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Number3");
            int no3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Number4");
            int no4 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Number5");
            int no5 = Convert.ToInt16(Console.ReadLine());

            int total = no1 + no2 + no3 + no4 + no5;
            Console.WriteLine("The total is=  " + total);

            Single avg = (Convert.ToSingle(no1) + Convert.ToSingle(no2) + Convert.ToSingle(no3) + Convert.ToSingle(no4) + Convert.ToSingle(no5)/5);
            Console.WriteLine("The Averange is = " + avg);
       

            Console.ReadLine();
        }
    }
}
