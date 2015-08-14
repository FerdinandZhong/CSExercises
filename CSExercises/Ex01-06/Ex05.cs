using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Double A;
            Console.WriteLine("input an Double ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:0.000}", Math.Sqrt(A));
            Console.ReadKey();
        }
        
    }
}
