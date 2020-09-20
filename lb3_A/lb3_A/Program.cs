using System;
using System.IO;

namespace lb3_A
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            double x,Z=0;
            int iteration, id=2, m1=3,m2=5;

            x = Convert.ToDouble(Console.ReadLine());
            iteration = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < iteration; i++)
            {
                if (i == 0)
                {
                    Z = (1.0 / 3.0) - (x / (2.0 * 4.0));
                    continue;
                }
                if(i%2==0)
                {
                    Z-= Math.Pow(x, id)/(m1*m2);
                    id++;
                    m1++;
                    m2++;
                }
                if (i % 2 != 0)
                {
                    Z += Math.Pow(x, id) / (m1 * m2);
                    id++;
                    m1++;
                    m2++;
                }
            }

            Console.Write(Z);

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();

        }
    }
}
