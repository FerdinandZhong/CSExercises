namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int a;
            do
            {
                try
                {
                    Console.Write("Please enter an integer: ");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    a = 0;
                }
            }
            while (a != 88);
            Console.WriteLine("\"Lucky you...\"");
            Console.ReadKey();
        }
    }
}
