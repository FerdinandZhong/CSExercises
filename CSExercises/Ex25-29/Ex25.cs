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
            int a = Convert.ToInt32(Console.ReadLine());
            int c;
            for (c = 1; c <= a; c++)
            {
                if (a % c == 0)
                    Console.WriteLine(c);
            }

            Console.WriteLine("Give another number: ");
            int z = Convert.ToInt32(Console.ReadLine());
            int x;
            for (x = z; x >= 1; x--)
            {
                if(z%x==0)
                    Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
