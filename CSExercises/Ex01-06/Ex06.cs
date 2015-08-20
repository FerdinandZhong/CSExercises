using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            double A ;
            Console.WriteLine("input an int ");
            try
            {
                A = Convert.ToInt32(Console.ReadLine());
                if (A >= 0)
                {
                    Console.WriteLine(Convert.ToInt32(Math.Sqrt(A)));
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("no square root of this integer");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("please input an integer");
                Console.ReadKey();
            }
        }
    }
}
