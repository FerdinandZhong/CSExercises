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
            while(G*G>N+0.00001||G*G<N-0.00001|| G*G!=N)
            {
               //Console.WriteLine(G);
               G = (G + N / G) / 2;
            }
            Console.WriteLine(G + "is the correct answer");
            Console.ReadKey();
         }
    }
}
