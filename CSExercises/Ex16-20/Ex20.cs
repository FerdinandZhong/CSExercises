namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex20
    {
        public static void Main(string[] args)
        {
            int T, D, M;
            double P2, P3, P4, P5,P6;
            Console.WriteLine("Enter quantity for TV: ");
            T = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity for DVD: ");
            D = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity for MP3: ");
            M = Convert.ToInt32(Console.ReadLine());
            P2 = T * 900;
            P3 = D * 500;
            P4 = M * 700;
            {
                if (P2 >= 5000 && P2 < 10000)
                {
                    P5 = P2 * 0.9;
                }
                else if (P2 >= 10000)
                {
                    P5 = P2 * 0.85;
                }
                else
                {
                    P5 = P2;
                }
            }
            {
                if (P3 >= 5000 && P3 < 10000)
                {
                    P6 = P3 * 0.9;
                }
                else if (P3 >= 10000)
                {
                    P6 = P3 * 0.85;
                }
                else
                {
                    P6 = P3;
                }
            }
            Console.WriteLine("Total price for this order is ${0:000.00}",P6+P5+P4);
            Console.ReadKey();
        }
    }
}