namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random Guessing= new Random();
            int a = Guessing.Next(0, 10),b,count=1;
            Console.Write("guess a number: ");
            b = Convert.ToInt32(Console.ReadLine());
            while (b != a)
            {
                Console.WriteLine("Try again");
                //try again 如果不放在上面则会一直出现，即使猜对。
                b = Convert.ToInt32(Console.ReadLine());
                //要多输入一次保证try again不会在猜对时依旧出现
                count++;  
            }
            Console.WriteLine("You Got it!");
            if (count <= 2)
                Console.WriteLine("You are a wizard!");
            else if (count > 2 && count <= 5)
                Console.WriteLine("You are a good guess");
            else if (count > 5 && count <= 10)
                Console.WriteLine("You are lousy");
                Console.ReadKey();
        }
    }
}
