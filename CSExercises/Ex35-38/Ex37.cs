namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence");
            string a = Convert.ToString(Console.ReadLine());
            string q = a.ToLower();
            string[] s = q.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int w;string S3 = " ";
            string S1 = " "; string x = " "; string X = " "; string S2 = " ";
            for (w = 0; w <= s.Length - 1; w++)
            {
                S1 = s[w];
                x = S1.Substring(0, 1);
                X = x.ToUpper();
                S2 = (S1.Substring(1, (S1.Length - 1))).Insert(0, X);
                S3 = S3 + S2 + " ";
            }
            string S4 = S3.Substring(1, (S3.Length - 1));
            Console.WriteLine("the title case is: {0}", S4);
            Console.ReadKey();
        }
    }
}
