namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int[] sales = new int[12];
            int d, A1, A2;
            string[] month = new string[]
            {
                "January","Feburary","March","April","May","June","July","Augest","September","October",
                "November","December"
            };
            int i;
            for (i = 1; i <= month.Length; i++)
            {
                Console.WriteLine("enter the sales for {0} ", month[i-1]);
                sales[i - 1] = Convert.ToInt32(Console.ReadLine());
            }
            int a;
            for(a=1;a<=12;a++)
            {
                Console.WriteLine("the sales on {0}\t is {1}\t", month[a - 1], sales[a- 1]);
            }
            int green, red, temp;
            string mon; 
            for(green=0; green<=10;green++)
            {
                for (red = green + 1; red <= 11; red++)
                {
                    if (sales[red] <= sales[green])
                    {
                        temp = sales[green];
                        sales[green] = sales[red];
                        sales[red] = temp;
                        mon = month[green];
                        month[green] = month[red];
                        month[red] = mon;
                        //已经按顺序排列好数列
                    }
                }
            }
            Console.WriteLine("Maximum Sales: {0}\t {1}", sales[11],month[11]);
            Console.WriteLine("Minimum Sales: {0}\t {1}", sales[0],month[0]);
            Console.WriteLine("Average Sales: {0}", (sales[0] + sales[1] + sales[2] + sales[3] + sales[4] + sales[5] + sales[6] + sales[7] + sales[8] + sales[9] + sales[10] + sales[11]) / 12);
            Console.ReadKey();     
        }
    }
}
