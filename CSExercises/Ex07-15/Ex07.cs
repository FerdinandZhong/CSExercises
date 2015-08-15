using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Double Salary, H, T, Income;
            Console.WriteLine("input the Salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());
            H = Salary * 0.1;
            T = Salary * 0.03;
            Income = H + T + Salary;
            Console.WriteLine("Total income is {0:0.00}",Income);
            Console.ReadKey();

        }
    }
}
