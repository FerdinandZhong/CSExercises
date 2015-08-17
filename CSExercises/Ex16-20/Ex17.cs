namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex17
    {
        public static void Main(string[] args)
        {
            string name, gender;
            int age;
            Console.WriteLine("Please input your name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please input your gender in M or F");
            gender = Convert.ToString(Console.ReadLine());
            Console.Write("Please input your age:");
            age = Convert.ToInt32(Console.ReadLine());
            if (gender == "M" || gender == "F")
            {
                if (gender == "M")
                {
                    if (age < 40)
                        Console.WriteLine("Good Morning Mr." + name);
                    else
                        Console.WriteLine("Good Morning Uncle " + name);
                }
                else
                {
                    if (age < 40)
                        Console.WriteLine("Good Morning Ms." + name);
                    else
                        Console.WriteLine("Good Morning Aunty" + name);
                }
            }
            else
                Console.WriteLine("You haven't input your gender correctly");
            Console.ReadKey();
        }
    }
}