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
            int A, B;
            try
            {
                Console.WriteLine("Please input a number A: ");
                A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input a number B: ");
                B = Convert.ToInt32(Console.ReadLine());
                while (A != B)
                {
                    if (A > B)
                        A = (A - B);
                    else
                        B = (B - A);
                }
                Console.WriteLine("HCF={0}", A);
                Console.WriteLine("LCM={0}", (A * B) / A);
            }
            catch
            {
                Console.WriteLine("Please input correctly");
                Console.WriteLine("Please input a number A: ");
                A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input a number B: ");
                B = Convert.ToInt32(Console.ReadLine());
                while (A != B)
                {
                    if (A > B)
                        A = (A - B);
                    else
                        B = (B - A);
                }
                Console.WriteLine("HCF={0}", A);
                Console.WriteLine("LCM={0}", (A * B) / A);

            }
            Console.ReadKey();
        }
    }
}
