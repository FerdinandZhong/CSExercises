namespace CSExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ex43
    {
        public static void Main(string[] args)
        {
            int i1;
            for (i1 = 0; i1 <= 10000; i1++)
            {
                string result = Hex(i1);
                Console.WriteLine(i1 + "\t" + result);
            }
            //string i2,i3;
            //i2= Convert.ToString(i1);
            //i3 = i2 + ("A");
            //Console.Write(i3);
            Console.ReadKey();
        }
        public static string Hex(int i)
        {
            double z, w,p,v;
            int v3,x,y;
            string q, e, r, t, u;
            string[] W = new string[6] { "A", "B", "C", "D", "E", "F" };
            x = 16;
            y = i / x;
            z = i - (y * x);
                if (y < 16)
                {
                    if (y < 10)
                    {
                        if (z <= 9 && z > 0)
                        {
                            w = y + z;
                            q = Convert.ToString(w);
                            return q;
                        }
                        else if (z > 9 && z < 16)
                        {
                            v = z - 9;
                            v3 = (int)v;
                            e = W[v3 - 1];
                            if (y == 0)
                            {
                                return e;
                            }
                            else
                            {
                                r = Convert.ToString(y);
                                t = r + e;
                                return t;
                            }
                        }
                        else if (z == 0)
                        {
                            p = y*10;
                            u = Convert.ToString(p);
                            return u;
                        }
                    }
                    else if (y >= 10 && y < 16)
                        if (z <= 9 && z > 0)
                        {
                            q = W[y - 10] + Convert.ToString(z);
                            return q;
                        }
                        else if (z > 9 && z < 16)
                        {
                            v = z - 9;
                            v3 = (int)v;
                            e = W[v3 - 1];
                            r = W[y - 10];
                            t = r + e;
                            return t;
                        }
                        else if (z == 0)
                        {
                            u = W[y - 10] + Convert.ToString("0");
                            return u;
                        }
                }

              //  else
               // {
                 //   if (y/16*Math.Pow(16,i1-1) < 10)
                   // {
                     //   if (z <= 9 && z > 0)
                       // {
                         //   w = y / 16 * Math.Pow(16, i1 - 1) * Math.Pow(10, i1) + z * Math.Pow(1, i1);
                           // q = Convert.ToString(w);
                         //   return q;
                       // }
                      //  else if (z > 9 && z < 16)
                      //  {
                      //      v = z - 9;
                      //      v3 = (int)v;
                      //      e = W[v3 - 1];
                      //      if (y == 0)
                      //      {
                       //         return e;
                        //    }
                       //     else
                       //     {
                       //         r = Convert.ToString(y);
                       //         t = r + e;
                       //         return t;
                       //     }
                       // }
                       // else if (z == 0)
                        //{
                         //   p = y * Math.Pow(10, i1);
                        //    u = Convert.ToString(p);
                        //    return u;
                      //  }
                   // }
                   // else if (y >= 10 && y < 16)
                   //     if (z <= 9 && z > 0)
                   //     {
                   //         q = W[y - 10] + Convert.ToString(z);
                   //         return q;
                    //    }
                   //     else if (z > 9 && z < 16)
                    //    {
                    //        v = z - 9;
                    //        v3 = (int)v;
                    //        e = W[v3 - 1];
                     //       r = W[y - 10];
                     //       t = r + e;
                     //       return t;
                     //   }
                     //   else if (z == 0)
                     //   {
                     //       u = W[y - 10] + Convert.ToString("0");
                     //       return u;
                     //   }
              //  }
           
            else if (y>=16)
            {
                int i3 = i, i4, i5;
                double i6 = Math.Log(i, 16);
                i5 = (int)i6;
                int i7 = i5;
                string[] a4 = new string[i5 + 1];
                string b = null;
                while (i3 >= 1)
                {
                        i4 = i3 % 16;
                        i3 = i3 / 16;
                        if(i4<=9&&i4>=0)
                        {
                            a4[i7] =Convert.ToString(i4);
                        }
                        else if(i4>9&&i4<=15)
                        {
                            a4[i7] = W[i4 - 10];
                        }
                    i7 = i7 - 1;
                    }
                for(int i8=0;i8<=i5;i8++)
                {
                    b = b + a4[i8];
                }
                return b;
            }
            return null;
        }
    }
}
