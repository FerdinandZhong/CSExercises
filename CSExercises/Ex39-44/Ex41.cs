namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex41
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please entry a string");
            string s1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please entry another string");
            string s2 = Convert.ToString(Console.ReadLine());
            bool result = InString(s1, s2);
            Console.Write(result);
            Console.ReadKey();
        }
        public static bool InString(string s1, string s2)
        {
            int a;
            string s3, s4, s5;
            s3 = s2.Substring(0, 1);
            if (s1.Length > s2.Length)
            {
                for (a = 0; a <= s1.Length - 1; a++)
                {
                    s4 = s1.Substring(a, 1);
                    if (s4.Equals(s3))
                    {
                        if (s1.Length - a >= s2.Length)
                        {
                            s5 = s1.Substring(a, s2.Length);
                            if (s5.Equals(s2))
                                return true;
                        }
                        else
                            return false;
                    }
                }
                return false;
            }
            else if (s1.Length == s2.Length) 
            {
                if (s1.Equals(s2))
                    return true;
                else
                    return false;
            }
            else
                return false;
            }
    }
}
