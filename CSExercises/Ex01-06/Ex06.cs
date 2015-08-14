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
            int A ;
            Console.WriteLine("input an int ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToInt32(Math.Sqrt(A)));
            Console.ReadKey();
        }
    }
}
