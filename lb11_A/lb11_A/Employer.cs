using System;
using System.Collections.Generic;
using System.Text;

namespace lb11_A
{
 
    class Employer
    {
        String ID { get; set; }
        public String Lname{ get; set; }
        public String Fname { get; set; }
        public String Email { get; set; }
        public float Salary { get; set; }
        public Boolean Skills{ get; set; }
        public float Tax { get; set; }
        // 52-3192486,Sturt,VГ©nus,osturt8 @abc.net.au, $1609.45, Editorial Illustrations,$224.27
        public static Employer Create (String str)
        {
            Employer p = new Employer();
            string[] e = str.Split(',');
            p.ID = e[0].Trim();
            p.Lname = e[2].Trim();
            p.Fname = e[1].Trim();
            string Email = e[3].Trim();
            p.Salary = Convert.ToSingle(e[4].TrimStart('$').Replace('.', ','));
            String Skills = e[5].Trim();
            p.Tax = Convert.ToSingle(e[6].TrimStart('$').Replace('.', ','));

            if (string.IsNullOrEmpty(Skills)) p.Skills = false;
            else p.Skills = true;
            if (string.IsNullOrEmpty(Email)) p.Email = "Not specified";

            return p;
        }

        public override string ToString()
        {
            String s = string.Format(
                "**********************************************************************\n" +
                $"\tID: {ID}, Name: {Fname}, Firstname: {Lname};\n\n" +
                $"\tEmail: {Email}, Salary: {Salary}, Skiils: {Skills}, Tax: {Tax}\n" +
                $"**********************************************************************\n");

            return s;
        }

        //private static String GenderToStr (GenderType g)
        //{
        //    if (g == GenderType.Male) return "M";
        //    return "F";
        //}

        //private static String HasChildrenToStr(Boolean g)
        //{
        //    if (g == true) return "+";
        //    return "-";
        //}

    }
}
