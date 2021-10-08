using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizacion
{
    class FactNumero
    {
        private int i, j;
        private int num;
        private int[] facts =  new int [50];
        private int pt;

        public FactNumero() {
            
        }

        public void factorizaNumero(int nf) {
            //Console.WriteLine("Dame el nuemro factor");
            num = nf;
            i = 2;
            j = 0;
            while (num > 1)
            {
                if (num % i == 0)
                {
                    num = num / i;
                    facts[j] = i;
                    j++;
                    i = 2;
                }
                else
                    i++;
            }
            Console.WriteLine("---LOS FACTORES PARA "+nf+" SON: ");
            for (i = 0; i < j; i++)
                Console.WriteLine(facts[i]);
        }

    }
}
