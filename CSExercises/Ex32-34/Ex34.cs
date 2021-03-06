namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] scores = new int[12, 4];
            {
                scores[0, 0] = 56; scores[0, 1] = 84; scores[0, 2] = 68; scores[0, 3] = 29;
                scores[1, 0] = 94; scores[1, 1] = 73; scores[1, 2] = 31; scores[1, 3] = 89;
                scores[2, 0] = 41; scores[2, 1] = 63; scores[2, 2] = 36; scores[2, 3] = 90;
                scores[3, 0] = 99; scores[3, 1] = 9; scores[3, 2] = 18; scores[3, 3] = 17;
                scores[4, 0] = 62; scores[4, 1] = 3; scores[4, 2] = 65; scores[4, 3] = 75;
                scores[5, 0] = 40; scores[5, 1] = 96; scores[5, 2] = 53; scores[5, 3] = 23;
                scores[6, 0] = 81; scores[6, 1] = 15; scores[6, 2] = 27; scores[6, 3] = 30;
                scores[7, 0] = 21; scores[7, 1] = 70; scores[7, 2] = 100; scores[7, 3] = 22;
                scores[8, 0] = 88; scores[8, 1] = 50; scores[8, 2] = 13; scores[8, 3] = 12;
                scores[9, 0] = 48; scores[9, 1] = 54; scores[9, 2] = 52; scores[9, 3] = 78;
                scores[10, 0] = 64; scores[10, 1] = 71; scores[10, 2] = 67; scores[10, 3] = 25;
                scores[11, 0] = 16; scores[11, 1] = 93; scores[11, 2] = 46; scores[11, 3] = 72;
            }
            int i, j;
            double T1=0;
            //先在外面给T1附个值，这样不会在后面报错
            for (i = 0; i <= 11; i++) 
            {

                for(j=0;j<=3;j++)
                {
                    T1 = T1 + scores[i, j];
                }
                Console.WriteLine("No.{0} student's total mark is {1}", i + 1, T1);
                T1 = 0;
            }
            int a, b, c; ;
            int A1 = 0, A2 = 0; int S1 = 0;
            for(a=0;a<=3;a++)
            {
                for(b=0;b<=11;b++)
                {
                    A1 = A1 + scores[b, a];
                }
                A2 = A1 / 12;
                Console.WriteLine("No.{0} subject's class average is {1}", a+1, A2);
                A1 = 0;
                for (c = 0; c <= 11; c++)
                {
                    S1 =((scores[c, a] - A2) * (scores[c, a] - A2)) + S1;
                }
                Console.WriteLine("No.{0} subject's deviation is {1:0.00}", a+1, Math.Sqrt(S1 / 12));
                S1=0;
            }
            int d, e,T2=0,T3=0;
            for(d=0;d<=11;d++)
            {
                for(e=0;e<=3;e++)
                {
                    T2 = T2 + scores[d, e];
                }
                T3 = T3 + T2;
                T2 = 0;
            }
            Console.WriteLine("Overall average for class is {0}", T3 / 48);
            Console.ReadKey();
        }  
    }
}
