using System;
using System.IO;

namespace lb7_A
{
    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
            int r = Convert.ToInt32(Console.ReadLine());
            int R = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
#endif      

#if !RELEASE
            int r = Convert.ToInt32(Console.ReadLine());
            int R = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
#endif
            Frustum frustum = new Frustum(r, R, h, l);
            frustum.TruncatedConeVolume(frustum);
            frustum.TruncatedConeArea(frustum);
            frustum.GetInfo();

            Frustum frustum2 = new Frustum();
            frustum2.TruncatedConeVolume(2, 4, 6);
            frustum2.TruncatedConeArea(2, 4, 6, 8);
            frustum2.GetInfo();

#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#endif
        }
    }
}
