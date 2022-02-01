using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.zadatak
{
    public class Neboder
    {
        private int visina, brojKatova;

        double prosjek;


        public Neboder(int visina, int brojKatova)
        {
            Visina = visina;
            BrojKatova = brojKatova;
            prosjek = visina / brojKatova;

            visina = visina + 10;
            brojKatova = brojKatova + 1;
            Console.WriteLine("Visina nebodera je " + visina.ToString()+ "m, broj katova je " + brojKatova.ToString()+",a prosjek visine kata je "+ prosjek.ToString()+" m.");
        }

        public int Visina { get => visina; set => visina = value; }
        public int BrojKatova { get => brojKatova; set => brojKatova = value; }

       

     

    }
    internal class Program
    {
        

        static void Main(string[] args)
        {

            Neboder Tower = new Neboder(200, 100);


           

            



            Console.ReadKey();

        }
    }
}
