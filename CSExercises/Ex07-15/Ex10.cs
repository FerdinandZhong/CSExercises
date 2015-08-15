using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Double X1, X2, Y1, Y2;
            Console.Write("input X1= ");
            X1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("input X2= ");
            X2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("input Y1= ");
            Y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("input Y2= ");
            Y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Distance= Square Root of [(X2-X1)^2+(Y2-Y1)^2]={0:0.000}", Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1)));
            Console.ReadKey();



        }
    }
}
