namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex27
    {
        public static void Main(string[] args)
        {
            double x,y;
            for(x=-5;x<=5;x++)
            {
                y =(2 * x * x - 4 * x + 3);
                Console.WriteLine("{0:0.0},{1:0.0}", x, y);
            }
            Console.ReadKey();
            int i=0;
            for (x = 1; x <= 5; x++)
            {
                Console.Write("{0}\t", x);
                y = (2 * x * x - 4 * x + 3);
                  for (i = 1; i <= y; i++)
                    {
                        Console.Write("*");
                    //一个母循环内，要运行完一个自循环，也就是在一个定了的y值后，就把到这个y值的*全打出来
                    }
                Console.WriteLine("\n");
              //自循环外运行母循环时断行  
            }
        Console.ReadKey();
        }
}
}
