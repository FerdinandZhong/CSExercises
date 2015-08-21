namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Double D, D1, D2;
            Console.Write("input the Distance in km: ");
            D = Convert.ToDouble(Console.ReadLine());
            D1 = Math.Ceiling(D * 10);
            D2 = D1 / 10;
            if (D2 <= 0.5)
                Console.WriteLine("Price=2.40$");
            else if (D2 > 0.5 && D2 <= 9)
                Console.WriteLine("Price={0:0.00}$", (2.40 + (D2 * 10 - 5) * 0.04));
            else if (D2 > 9)
                Console.WriteLine("Price={0:0.00}$", ((2.40 + 85 * 0.04 + (D2 * 10 - 90) * 0.05)));
            Console.ReadKey();
        }
    }
}