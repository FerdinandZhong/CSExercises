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
            int A;
            for (A = 5; A <= 10000; A++)
            {
                int i=2;
               while(A%i!=0&&i<=A/2)
                {
                    i++;
                }
               //此循环保证了如果不能余0就要继续增加i的值，直到加到A/2
                if (i > A / 2)
                    Console.WriteLine("{0}", A);
                // if (i > A / 2)次判断式保证了输出的不是因为可以整除而跳出循环的实数。
            }
            Console.ReadKey();
        }
    }
}
