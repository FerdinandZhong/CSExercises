namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a number: ");
           long a = Convert.ToInt64(Console.ReadLine());
           long c;
           long a1 = 1;
            for (c = 0; c <= a-1; c++)
            {
                a1 = a1 * (a - c);
            }
            Console.WriteLine("the factorial is "+a1);
            Console.ReadKey();
            Console.WriteLine("Give another number: ");
            long z = Convert.ToInt64(Console.ReadLine());
            long x;
            long z1 = 1;
            for (x = z-1; x >= 0; x--)
            {
                z1 = z1 * (z - x);
            }
            Console.WriteLine("the factorial is "+z1);
            Console.ReadKey();
        }
    }
}
