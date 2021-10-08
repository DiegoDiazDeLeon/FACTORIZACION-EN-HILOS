using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizacion
{
    class CreaNums
    {
        int nuser;
        public string nums = "";
        public CreaNums(int nuser) {
            this.nuser = nuser;
            Random();

        }
        public void numeros()
        {
                Random r = new Random();
                int num = r.Next(2, 100);
                nums += String.Format("{0} {1} {2}\n",num,0,0);
            
        }

        public void trinomios()
        {
            Random r = new Random();
            Random x = new Random();

            int numx = x.Next(0, 3);
            
            if (numx == 1)
            {
                //genera perfecto
                int numa = 1;
                int ram = r.Next(1, 100);
                int numc = ram * ram;
                int numb = ram * 2;
                nums += String.Format("{0} {1} {2}\n", numa, numb, numc);

            }
            else 
            {
                //genera uno no perfecto
                int numa = r.Next(1, 9);
                int numb = r.Next(1, 50);
                int numc = r.Next(1, 100);
                nums += String.Format("{0} {1} {2}\n", numa, numb, numc);
            }
            
        }

        public void Random()
        {
            
            for (int i = 0; i < nuser; i++)
            {
                Random l = new Random();
                int tn = l.Next(1, 3);
                //Console.WriteLine(tn);
                if (tn == 1)
                {
                    numeros();
                }
                else if (tn==2) {
                    trinomios();
                }
               System.IO.File.WriteAllText(@"C:\Users\yeyok\Documents\TAREAS UASLP\INTERFACES GRAFICAS\factor.txt", nums);
            }
           // System.IO.File.WriteAllText(@"C:\Users\yeyok\Documents\TAREAS UASLP\INTERFACES GRAFICAS\factor.txt", nums);


        }

    }

}
