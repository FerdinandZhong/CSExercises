namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 0.05 to 3.50");
            double i = Convert.ToDouble(Console.ReadLine());
            double i1 = Math.Round(i, 2);
            double i2 = i1 * 100;
            string[] result = Getdenomination(i2);
            int p;
            for (p = 0; p <= result.Length - 1; p++)
            {
                Console.WriteLine(result[p]);
            }
            Console.ReadKey();
        }
        public static string[] Getdenomination(double i2)
        {
            int i=0;
            string[] a = new string[20];
            while (i2>=100)
            {
                i2 = i2 - 100;
                a[i] ="100c";
                i = i + 1;
            }
            while(i2>=50)
            {
                i2 = i2 - 50;
                a[i] = "50c";
                // b = b + 1;
                i = i + 1;
            }
            while(i2>=20)
            {
                i2 = i2 - 20;
                a[i] = "20c";
                //d = d + 1;
                i = i + 1;
            }
           while(i2>=10)
            {
                i2 = i2 - 10;
                a[i] = "10c";
                // f = f + 1;
                i = i + 1;
            }
            string w = null;
            if (i2 >= 5)
            {
               w ="5c";
            }
            //int x;string z = null;
            //for (x = 0; x <= 3; x++)
            //  z = z + a[x]+" ";
            a[i] = w;
            return a;
        }

    }
}
