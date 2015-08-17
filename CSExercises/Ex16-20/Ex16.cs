namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex16
    {
        public static void Main(string[] args)
        {
            string name, gender;
            Console.WriteLine("Please input your name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please input your gender in M or F");
            gender = Convert.ToString(Console.ReadLine());
            if (gender == "M" || gender == "F")
            {
                if (gender == "M")
                    Console.WriteLine("Good Morning Mr." + name);
                else
                    Console.WriteLine("Good Morning Ms." + name);
            }
            else
                Console.WriteLine("You haven't input your gender correctly");
            Console.ReadKey();    
        }
    }
}