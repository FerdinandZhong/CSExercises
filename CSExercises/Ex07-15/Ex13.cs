using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Double D, P1, P2,P3,P4;
            Console.Write("input the Distance: ");
            D = Convert.ToDouble(Console.ReadLine());
            P1 = 2.40 + D * 0.4;
            P2 = P1*10;
            P3 = Math.Ceiling(P2);
            P4 = P3 / 10;
            Console.WriteLine("Price={0:0.00}$", P4);
            Console.ReadKey();
        }
    }
}
