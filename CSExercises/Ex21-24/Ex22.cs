namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int A, B,A1,B1;
                Console.WriteLine("Please input a number A: ");
                A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input a number B: ");
                B = Convert.ToInt32(Console.ReadLine());
            A1 = A;
            B1 = B;
                while (A1 != B1)
                {
                    if (A1 > B1)
                        A1 = (A1 - B1);
                    else
                        B1 = (B1 - A1);
                }
                Console.WriteLine("HCF={0}", A1);
                Console.WriteLine("LCM={0}", (A * B) / A1);
            Console.ReadKey();
        }
    }
}
