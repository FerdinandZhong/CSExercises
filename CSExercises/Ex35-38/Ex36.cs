namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence");
            string a = Convert.ToString(Console.ReadLine());
            string q = a.ToLower();
            string[] s = q.Split(new char[] { ' ', '.', ',', '_', '!', '?', ':', '\"', '\'' }, StringSplitOptions.RemoveEmptyEntries);
            int w; string W = "None";
            for(w=0;w<=s.Length-1;w++)
            {
                W = W + s[w];
            }
            int u = W.Length;
            string W2 = W.Substring(4,u-4);
            int b = W2.Length;
            int d; string y=W2;
            for (d = b-1; d >= 0; d--)
            {
                string x = W2.Substring(d, 1);
                y = y + x;
                //字符串也可以相加
            }
            string z = y.Substring(b, b);
            if(W2.Equals(z))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

            Console.ReadKey();
        }
    }
}
