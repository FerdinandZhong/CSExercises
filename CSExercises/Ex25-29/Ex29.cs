namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int c=1,d=0;
            for (c=1; c <= a/2;c++)
            {
                if (a % c == 0)
                {
                    d = d + c;
                }
            }
            if (d == a)
                Console.WriteLine("Perfect Number");
            else
                Console.WriteLine("Not Perfect Number");
            Console.ReadLine();
        }
    }
}
