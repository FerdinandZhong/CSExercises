namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Double a, b, c, d, E;
            Console.WriteLine("input a 3 digits numble: ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Math.Floor(a / 100);
                c = Math.Floor(a / 10 - b * 10);
                d = a - b * 100 - c * 10;
                E = Math.Pow(b, 3) + Math.Pow(c, 3) + Math.Pow(d, 3);
                if(a>=100 && a<=999)
                {
                    if (E == a)
                    {
                        Console.WriteLine("this is an \"Armstrong Number\"");
                    }     
                    else
                        Console.WriteLine("this is not an \"Armstrong Number\"");
                }
                else
                {
                    Console.WriteLine("Please input a 3-digit number");
                }
            }
            catch
            {
                Console.WriteLine("Please don't make fool of me");
            }
            Console.ReadKey();
        }
    }
}