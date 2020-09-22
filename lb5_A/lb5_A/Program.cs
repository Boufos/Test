using System;
using System.IO;

namespace lb5_A
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                TextWriter save_out = Console.Out;
                TextReader save_in = Console.In;
                var new_out = new StreamWriter(@"output.txt");
                var new_in = new StreamReader(@"input.txt");
                Console.SetOut(new_out);
                Console.SetIn(new_in);

               int N= Convert.ToInt32(Console.ReadLine());
               int M = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("***input matrix***");

                int [,] massiv = new int[N,M];
                Random rnd = new Random(DateTime.Now.Second);

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {

                        Console.Write($"{massiv[i, j] = rnd.Next(100)} ");

                    }
                    Console.WriteLine();

                }

                Console.WriteLine("***Average***");

                for (int i = 0; i < N; i++)
                {
                    int sum = 0;
                    int kol = 0;

                    for (int j = 0; j < M; j++)
                    {

                        if(massiv[i,j]%2==0)
                        {
                            sum += massiv[i, j];
                            kol++;
                        }

                    }
                    Console.WriteLine($"{sum/kol} ");

                }

                Console.WriteLine("***Modifed matrix***");

                for (int i = 0; i < N; i++)
                {
                    int average = 0;

                    for (int j = 0; j < M; j++)
                    {

                        average += massiv[i, j];

                    }
                    average /= M;

                    for (int j = 0; j < M; j++)
                    {

                        if (massiv[i, j] < average) Console.Write(" q ");
                        else Console.Write(" z ");

                    }
                    Console.WriteLine();

                }


                Console.SetOut(save_out); new_out.Close();
                Console.SetIn(save_in); new_in.Close();


            }
        }
    }
}
