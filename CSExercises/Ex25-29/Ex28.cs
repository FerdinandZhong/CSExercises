namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex28
    {
        public static void Main(string[] args)
        {
            int A, i;
            Console.WriteLine("input an integer");
            A = Convert.ToInt32(Console.ReadLine());
            i = 2;
            if(A==1)
                Console.WriteLine("Not Prime");
           else if ( A == 2 || A == 3)
                Console.WriteLine("Prime");
            else
            {
                while (i < A)
                {
                    if (A % i == 0)
                    {
                        Console.WriteLine("Not Prime");
                        i = A;
                    }
                    else
                        i = i + 1;
                    {
                        if (i ==A/2)
                            Console.WriteLine("Prime");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
