namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int a,c;
            for (a = 1; a <= 1000; a++)
            {
                int d = 0;
                for (c = 1; c <= a / 2; c++)
                {
                    if (a % c == 0)
                    {
                        d = d + c;
                    }
                }
                if (d == a)
                    Console.WriteLine("{0}", a);
            }
            Console.ReadKey();
        }
    }
}
