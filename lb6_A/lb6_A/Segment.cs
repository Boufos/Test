using System;


namespace lb6_A
{
    class Segment
    {
        public int  X1 { get; set; }
        public int X2 { get; set; }
        public int Y1 { get; set; }
        public int Y2 { get; set; }
        public Segment(int x1, int x2, int y1, int y2)
        {
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
        }

        public void Segmentlength()
        {
            Console.WriteLine($"\nLength sement = {Math.Sqrt(Math.Pow(X2-X1,2) + Math.Pow(Y2 - Y1, 2))}");
        }

        public void Distance()
        {
            Console.WriteLine($"\nDistance to start of leg: ({X1},{X2})");
            Console.WriteLine($"Distance to end of line: {X1+Y1},{X2+Y2}");
        }

        public void GetInfo()
        {
            Console.WriteLine("\n*****Segment*****\n\n" +
                                 "-----------------\n\n"+
                                 "*****************");
            Console.WriteLine($"Start of segment: {X1},{X2}");
            Console.WriteLine($"End of segment: {Y1},{Y2}");
        }

    }            
}
