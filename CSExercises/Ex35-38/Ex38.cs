namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex38
    {
        public static void Main(string[] args)
        {
            int[] M = new int[]
                {63,29,75,82,55};
            string[] N = new string[]
            {
                "John","Venkat","Mary","Voctor","Betty"
            };
            int green, red;
            int temp;
            string name1;
            for (green=0;green<=M.Length-2;green++)
            {
                for (red = green + 1; red <= M.Length - 1; red++)
                {
                    if (M[red] >= M[green])
                    {
                        temp = M[green];
                        M[green] = M[red];
                        M[red] = temp;
                        name1 = N[green];
                        N[green] = N[red];
                        N[red] = name1;
                    }
                }
            }
            Console.WriteLine("by marks: \n");
           for(int x=0;x<=N.Length-1;x++)
            {
                Console.WriteLine("{0}\t{1}\n", N[x], M[x]);
            }
            Console.ReadKey();
            string name2;
            int temp2;
            for(int blue=0;blue<=N.Length-2;blue++)
            {
                for (int black = blue + 1; black<= M.Length - 1; black++)
                {
                    int w = N[blue].CompareTo(N[black]);
                    if(w==1)
                    {
                        name2 = N[blue];
                        N[blue] = N[black];
                        N[black] = name2;
                        temp2 = M[blue];
                        M[blue] = M[black];
                        M[black] = temp2;
                    }
                }
            }
            Console.WriteLine("by names: \n");
            for (int x = 0; x <= N.Length - 1; x++)
            {
                Console.WriteLine("{0}\t{1}\n", N[x], M[x]);
            }
            Console.ReadKey();
        }
    }
}
