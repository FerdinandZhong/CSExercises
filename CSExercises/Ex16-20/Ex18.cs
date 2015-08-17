namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex18
    {
        public static void Main(string[] args)
        {
            int grade;
            Console.WriteLine("Plaese input the marks: ");
            grade = Convert.ToInt32(Console.ReadLine());
            if (grade <= 100 && grade >= 0)
            {
                if (grade <= 100 && grade >= 80)
                    Console.WriteLine("You scored " + grade + "which is A grade");
                else if (grade <= 79 && grade >= 60)
                    Console.WriteLine("You scored " + grade + "which is B grade");
                else if (grade <= 59 && grade >= 40)
                    Console.WriteLine("You scored " + grade + "which is C grade");
                else if (grade <= 39 && grade >= 0)
                    Console.WriteLine("You scored " + grade + "which is F grade");
            }
            else
                Console.WriteLine("**Error**");
            Console.ReadKey();
        }
    }
}