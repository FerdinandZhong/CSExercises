namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex39
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a number: ");
            long a = Convert.ToInt64(Console.ReadLine());
            long M = Factorial(a);
            Console.WriteLine("factorial of the number is: " +M);
            Console.ReadKey();
        }
        public static long Factorial(long n)
        {
            int i;
            long N=n;
            if (n != 0)
            {
                for (i = 1; i <=n-1; i++)
                {
                    N = N * (n - i);
                }
                return N;
            }
            else
            {
                return 0;
            }
        }
    }
}
