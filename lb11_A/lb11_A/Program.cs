using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace lb11_A
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f_in = new StreamReader("lr11_09.csv");

#if !DEBUG

            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter(@"lr11_output.txt");
            Console.SetOut(new_out);
#endif
            List<Employer> all = new List<Employer>();

            try
            {
                String line = f_in.ReadLine();
                while ((line = f_in.ReadLine()) != null)
                {
     
                    all.Add(Employer.Create(line));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("********************************TASK 1********************************\n" +
                "\t\t\tEmployee with minimum wage\n");
            float tSalary = (from p in all select p.Salary - p.Tax).Min();
            Employer nameEmployerMin = (from p in all where p.Salary - p.Tax == tSalary select p).First();
            Console.Write(nameEmployerMin);

            Console.WriteLine("\n********************************TASK 2********************************\n" +
                "\t\tThe number of people without skill\n");
            int SkillFalse = all.FindAll(p => p.Skills == false).ToList().Count;
            Console.WriteLine($"Find {SkillFalse} persons");

            Console.WriteLine("\n********************************TASK 3********************************\n" +
                "\tAverage salary of employees with and without e-mail\n");
            float EmailFalse = (from p in all where p.Email == "Not specified" select p.Salary).Average();
            float EmailTrue = (from p in all where p.Email != "Not specified" select p.Salary).Average();
            Console.WriteLine($"Average salary for employees with e-mail: {EmailTrue}");
            Console.WriteLine($"Average salary for employees without e-mail: {EmailFalse}");

            Console.WriteLine("\n********************************TASK 4********************************\n" +
                "\t\t\tTotal tax amount\n");
            float sumTax = (from p in all select p.Tax).Sum();
            Console.WriteLine($"Total tax amount: {sumTax}");
#if !DEBUG
            Console.SetOut(save_out);
            new_out.Close();
#endif
        }
    }
}
