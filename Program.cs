using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE EL N DE NUMEROS O TRINOMIOS A GENERAR ALTERATORIAMENTE");
            int numeros=int.Parse(Console.ReadLine());
            System.Console.ForegroundColor = ConsoleColor.Red;

            new CreaNums(numeros);
            DateTime inicial = DateTime.Now;

            Hilos h = new Hilos();

            while (h.c != 4) ;
            DateTime final = DateTime.Now;
            Console.WriteLine(inicial - final);

            Console.WriteLine("TERMINADO");
            Console.ReadKey();
            
        }
    }
}
