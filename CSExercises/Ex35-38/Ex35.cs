namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a phrase");
            string a = Convert.ToString(Console.ReadLine());
            int b = a.Length;
            int c=0,d;
            for(d=0; d<=b-1;d++)
            {
                string x = a.Substring(d, 1);
                if (x.Equals("a") || x.Equals("e") || x.Equals("i") || x.Equals("o") || x.Equals("u"))
                    c++;
            }
            Console.WriteLine("Total number of vowels: {0}", c);
            int f, g = 0, h = 0, j = 0, k = 0, l = 0;
            for(f=0;f<=b-1;f++)
            {
                string y= a.Substring(f, 1);
                if (y.Equals("a"))
                    g++;
                else if (y.Equals("e"))
                    h++;
                else if (y.Equals("i"))
                    j++;
                else if (y.Equals("o"))
                    k++;
                else if (y.Equals("a"))
                    l++;
            }
            Console.WriteLine("Number of a: {0}", g);
            Console.WriteLine("Number of e: {0}", h);
            Console.WriteLine("Number of i: {0}", j);
            Console.WriteLine("Number of o: {0}\nNumber of u: {1}", k,l);
            Console.ReadKey();
        }
    }
}
