using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap1bai3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(8,2);
            int resultCong = calculator.Cong();
            int resultTru = calculator.Tru();
            int resultNhan = calculator.Nhan();
            int resultChia = calculator.Chia();
            Console.WriteLine("Cong: " + resultCong);
            Console.WriteLine("Tru: " + resultTru);
            Console.WriteLine("Nhan: " + resultNhan);
            Console.WriteLine("Chia: " + resultChia);
            Console.ReadLine();
        }
    }
}
