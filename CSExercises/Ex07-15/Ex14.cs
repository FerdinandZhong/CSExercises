namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex14
    {
        public static void Main(string[] args)
        {

                Double a, b, c, S;
                Console.Write("Input a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input c: ");
                c = Convert.ToDouble(Console.ReadLine());
                if (a + b > c && a + c > b && b + c > a)
                {
                    S = (a + b + c) / 2;
                    Console.WriteLine("Area={0:0.00}", Math.Sqrt(S * (S - a) * (S - b) * (S - c)));
                }
                else
               {
                Console.WriteLine("Please input the correct value of a,b,c, \n make it follow \"(a + b > c) & (a + c > b) & (b + c > a) \"");
               }
            Console.ReadLine();
        }
    }
}