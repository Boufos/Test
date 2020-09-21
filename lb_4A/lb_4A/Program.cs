using System;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace lb_4A
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter the length of the array: ");
                TextWriter save_out = Console.Out;
                var new_out = new StreamWriter(@"output.txt");
                Console.SetOut(new_out);
     
                int kol;
                kol = Convert.ToInt32(Console.ReadLine());
 

                int[] massiv = new int[kol];
                Random rnd = new Random(DateTime.Now.Second);
                int max5 = 0;
                int min3 = 101;
                int sum10 = 0;

                for (int i=0; i<kol;i++)
                {
                    massiv[i] = rnd.Next(100);
                    if (massiv[i] % 5 == 0 && massiv[i] > max5) max5 = massiv[i];
                    if (massiv[i] % 3 == 0 && massiv[i] < min3) min3 = massiv[i];
                    if (massiv[i] % 10 == 0) sum10 += massiv[i];

                }
                Console.WriteLine($"The maximum element among all multiples of 5: {max5}");
                Console.WriteLine($"Minimum element among all multiples of 3: {min3}");
                Console.WriteLine($"The sum of the elements that are divisible by 10: {sum10}");


                Console.SetOut(save_out); new_out.Close();
       

            }
        }
    }
}
