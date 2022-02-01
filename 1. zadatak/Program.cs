using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.zadatak
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int x, y, z;

            Console.WriteLine("*Provjera za pravokutni trokut*");
            Console.WriteLine("Upiši stranicu trokuta x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upiši stranicu trokuta y:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upiši stranicu trokuta z(hipotenuza):");
            z = Convert.ToInt32(Console.ReadLine());

            if(x>0 && y>0 && z > 0)
            {
                if((x*x)+(y*y)==z*z)
                {
                    Console.WriteLine("Vaš trokut je pravokutan");
                }
                else
                {
                    Console.WriteLine("Vaš trokut nije pravokutan");
                }
            }
            else
            {
                Console.WriteLine("Unesite broj veći od 0!");
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
