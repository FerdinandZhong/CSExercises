using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Double D;
            Console.Write("input the Distance: ");
            D = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Price=${0:0.00}", 2.40 + D * 0.4);
            Console.ReadKey();



            
        }
    }
}
