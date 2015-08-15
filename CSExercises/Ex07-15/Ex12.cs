using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Double D, P1,P2;
            Console.Write("input the Distance: ");
            D = Convert.ToDouble(Console.ReadLine());
            P1 = 2.40 + D * 0.4;
            P2 = Math.Round(P1, 1);
            Console.WriteLine("Price={0:0.00}$", P2);
            Console.ReadKey();
        }
    }
}
