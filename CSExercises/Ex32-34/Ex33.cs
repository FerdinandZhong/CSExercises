namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] array = new int[]
            {
               86,35,41,49,89,51,11,71,50,75,25,58,40,14,44,3,63,81,93,79
            };
            int green, red,temp,i,a;
            for(green=0;green<=array.Length-2;green++)
            {
                Console.WriteLine("progress {0}", green + 1);
                for (red=green+1;red<=array.Length-1;red++)
                {
                    if (array[red] >= array[green])
                    {
                        temp = array[green];
                        array[green] = array[red];
                        array[red] = temp;
                    }
                }
                for (i = 0; i <= array.Length - 1; i++)
                {
                    Console.Write("{0}\t", array[i]);
                }
            }
            Console.WriteLine("see the final: ");
            for (a = 0; a <= array.Length - 1; a++)
            {
                Console.Write("{0}\t", array[a]);
            }
            Console.ReadKey();
        }
    }
}
