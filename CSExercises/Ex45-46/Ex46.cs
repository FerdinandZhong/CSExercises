namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex46
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("number" + "\t" + "count");
            int[] a = new int[] { 0,1,2,3,4,5,6,7,8,9 };
            Random number = new Random();
            int[] r = new int[50];
            int b,c,n=0;
            for (int i = 0; i <= 49; i++)
            {
                r[i] = number.Next(0,10 );
            }
            for (b = 0; b <= 9; b++)
            {
                for (c = 0; c <= 49; c++)
                {
                    if (r[c] == a[b])
                        n = n + 1;
                }
                Console.WriteLine(b + "\t" + n);
                n = 0;
            }
            Console.ReadKey();
            Console.WriteLine("number");
            for (b = 0; b <= 9; b++)
            {
                Console.Write(a[b] + "\t");
                for (c = 0; c <= 49; c++)
                {
                    if (r[c] == a[b])
                        Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
