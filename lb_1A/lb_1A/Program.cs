using System;

namespace lb_1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Personal information (task № 1)\n\n" +
             "\tLaboratory work № 1\n" +
            "\tFull name: Teremyaeva O.V. \n" +
            "\tDate of birth: 07/30/2000\n" +
            "\tLocation: Armavir\n" +
            "\tFavorite subject at school: computer science \n" +
            "\tHobby: drawing, reading\n");

            //Se = w111 + bt - x +y *w
            int will, bt, x, y, w;
            will = w = 5;
            bt = 2;
            x = y = 4;
            Console.WriteLine($"Calculate the formula(task number 2)\n\n" +
                $"\tDefault formula: Se = w111 + bt - x +y *w;\n" +
                $"\tSe = {will} + {bt} - {x} + {y} * {w};\n" +
                $"\tSe = {will + bt - x +y *w};\n");
        }
    }
}
