using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizacion
{
    class FactTrinomio
    {
       private int a, b, c;

        public FactTrinomio() { 
         
        }

        public void factorizarTrinomio(int na, int nb, int nc) {

            //Console.WriteLine("factorizacion de un trinomio cuadrado perfecto\n");
            //Console.WriteLine("de la forma ax^2+bx+c\n");
            //Console.WriteLine("ingrese los valores de a, b, y c\n");
            //Console.WriteLine("ingrese el valor de a\n");
            a = na;
            //Console.WriteLine("ingrese el valor de b\n");
            b = nb;
            //Console.WriteLine("ingrese el valor de c\n");
            c = nc;

            int ra = Convert.ToInt32(Math.Sqrt(a));
            int rc = Convert.ToInt32(Math.Sqrt(c));
            
            if (2 * ra * rc == Math.Abs(b))
            {
                //Console.WriteLine("es un trinomio cuadrado perfecto\n");
                if (b < 0)
                {
                    
                    Console.WriteLine("+++LA FACTORIZACION DE " + a + "x^2+" + b + "x" + c + " ES :");
                    Console.WriteLine("(" + ra + "x" + "+" + rc + ")^2");
                }
                else
                {
                    Console.WriteLine("+++LA FACTORIZACION DE " + a + "x^2+" + b + "x+" + c + " ES: ");
                    Console.WriteLine("("+ra+"x" + "+" + rc+")^2");
                }
            }
            else
            {
                Console.WriteLine("!!!"+a + "x^2+" + b + "x+" + c + " NO ES UN TRINOMIO AL CUADRADO PERFECTO ");
            }

        }

    }
}
