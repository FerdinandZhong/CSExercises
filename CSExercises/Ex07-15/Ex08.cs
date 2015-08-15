using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Double C;
            Console.WriteLine("Input a Centigrade Scale Temperature");
            C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("F=1.8C+32={0:0.00}", 1.8 * C + 32);
            Console.ReadKey();
            
        }
    }
}
