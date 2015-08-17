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
            int T, D, M, P1, P2;
            Console.WriteLine("Enter quantity for TV: ");
            T = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity for DVD: ");
            D = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity for MP3: ");
            M = Convert.ToInt32(Console.ReadLine());
            P1 = T * 900 + D *500+M*700;
            P2 = T * 900 + D * 500;
            if (P1 > 5000 && P1 <= 10000)
                Console.WriteLine("Total Price for this order is ${0:##000}", P2 * 0.9 + M * 700);
            else if (P1 > 10000)
                Console.WriteLine("Total Price for this order is ${0:##000}", P2 * 0.85 + M * 700);
            else if (P1 < 5000)
                Console.WriteLine("Total Price for this order is ${0:##000}", P1);
            Console.ReadKey();
        }
    }
}