using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            int x;
            Console.WriteLine("input x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y=2x^2-4x+3={0:0}", 2 * x * x - 4 * x + 3);
            Console.ReadKey();
           
        }
    }
}
