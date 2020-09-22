using System;
using System.Collections.Generic;
using System.Text;

namespace lb7_A
{
    class Frustum
    {
        public int r { get; set; }
        public int R { get; set; }
        public int h { get; set; }
        public int l { get; set; }

        public Frustum()
        {
            
        }
        public Frustum(int r, int R, int h, int l)
        {
            this.r = r;
            this.R = R;
            this.h = h;
            this.l = l;
        }

        public void TruncatedConeVolume(Frustum f)
        {
            Console.WriteLine($"Truncated cone volume: {(1.0/3.0*3.14*f.h)*((f.r*f.r)+(f.r*f.R)+(f.R*f.R))}");
        }
        public void TruncatedConeVolume(int h, int r, int R)
        {
            Console.WriteLine($"Truncated cone volume: {(1.0 / 3.0 * 3.14 * h) * ((r * r) + (r * R) + (R * R))}");
        }

        public void TruncatedConeArea(Frustum f)
        {
            Console.WriteLine($"Truncated cone area: {(3.14*f.R*f.R)+(3.14*f.r*f.r)+(3.14*(f.R+f.r)*f.l)}");
        }

        public void TruncatedConeArea(int h, int r, int R, int l)
        {
            Console.WriteLine($"Truncated cone area: {(3.14 * R * R) + (3.14 * r * r) + (3.14 * (R + r) * l)}");
        }

        public void GetInfo()
        {
            Console.WriteLine("\n*****Segment*****\n\n" +
                                 "-----------------\n\n" +
                                 "*****************");

            Console.WriteLine($"Top base radius: {r}\n" +
                $"Bottom base radius: {R}\n" +
                $"Truncated cone height: {h}\n" +
                $"Truncated cone generatrix: {l}\n");
            Console.WriteLine("-----FINISH-----");

        }

    }
}
