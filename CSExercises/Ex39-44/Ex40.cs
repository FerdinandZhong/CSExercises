using System.Data.SqlClient;

namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex40
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("give a number(1-25): ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("square root: "+ SQT(a));
            Console.ReadKey();
        }

        public static double SQT(int y)
        {
            if (1 <= y && y <= 25)
            {
                double N = Math.Sqrt(y);
                return N;
            }
            else
                return 0;
        }
    }
}
