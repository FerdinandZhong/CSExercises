namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex24
    {
        public static void Main(string[] args)
        {
            int N;
            Console.Write("Write a number: ");
            N = Convert.ToInt32(Console.ReadLine());
            Random number = new Random();
            Double G = number.Next(0, (int)N);
            //.next()这个函数只能取整数，
            //.nextdouble()可以取非整数，但是范围只是在0到1之间，要通过运算来扩大取值范围。
            //例如想在1到100之间取值，就要先x=number.nextdouble(),然后x乘以99再加1，则取值范围改为了1到100.
            while(Math.Round(G*G,5)>N+0.00001|| Math.Round(G * G, 5) < N-0.00001)
            {
              // Console.WriteLine(G);
               G = (G + N / G) / 2;
            }
            Console.WriteLine(G + "is the correct answer");
            Console.ReadKey();
         }
    }
}
