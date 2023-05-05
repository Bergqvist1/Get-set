using System;
using Get_set;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Minklass make = new Minklass();
            Minklass cc = new Minklass();
            Minklass hp = new Minklass();


            Console.WriteLine("Skriv in ett MC-Märke märke:");
            make.Mc = Console.ReadLine();

            Console.WriteLine("Skriv in motorns cc");
            cc.Mc = Console.ReadLine();

            Console.WriteLine("Skriv in hästkraften");
            hp.Mc = Console.ReadLine();

            Console.WriteLine("Motorcykeln är en" + " " + make.Mc + " " + "på " + cc.Mc + " " + "cc" + " " + "med" + " " + hp.Mc + "hp");

            Bil p = new Bil("BMW", 1980, "M3");
            Bil p1 = new Bil("Mercedes", 2005, "C63");
            Bil p2 = new Bil("Audi", 2018, "RS6");

            Console.WriteLine(p.b + " " + p.å + " " + p.m);
            Console.WriteLine(p1.b + " " + p1.å + " " + p1.m);
            Console.WriteLine(p2.b + " " + p2.å + " " + p2.m);

        }
    }
}
