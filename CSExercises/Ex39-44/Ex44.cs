namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex44
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please entry a string");
            string s1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please entry a character");
            char c1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please entry another character");
            char c2= Convert.ToChar(Console.ReadLine());
            string s2 = Substitute(s1, c1, c2);
            Console.WriteLine("new string is:{0}", s2);
            Console.ReadKey();
        }
        public static string Substitute(string s, char c1, char c2)
        {
            string[] S = s.Split(c1);
            if (S.Length == 1)
            {
                string r1 = ("there is no ") + ("\"")+c1 + ("\"")+(" in this string");
                return r1;
            }
            else
            {
                int i;string r2=S[0];
                for(i=1;i<=S.Length-1;i++)
                {
                    r2 = r2 + c2 + S[i];
                }
                return r2;
            }
        }
    }
}
