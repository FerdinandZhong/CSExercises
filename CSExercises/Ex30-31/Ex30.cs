namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int A; int i,c=0;
            for (A = 5; A <= 10000; A++)
            {
                for (i = 1; i <= A; i++)
                {
                    if (A % i == 0)
                        c = c + 1;
                }
                if (c == 2)
                //while(A%i!=0&&i<=A/2)
                // {
                //i++;
                // }
                //此循环保证了如果不能余0就要继续增加i的值，直到加到A/2
                // if (i > A / 2)
                {
                    Console.WriteLine("{0}", A);
                }
                c=0;
                // if (i > A / 2)次判断式保证了输出的不是因为可以整除而跳出循环的实数。
            }
            Console.ReadKey();
        }
    }
}
