using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.zadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prijestupne godine\n");
            for(int godine=1900; godine < 2100; godine++)
            {
                if (godine % 400 == 0 || godine % 4 == 0 && godine%100!=0)
                {
                    Console.WriteLine(godine + "\n");
                }
            }
            
            
            
       
            
            Console.ReadKey();
        }
    }
}
