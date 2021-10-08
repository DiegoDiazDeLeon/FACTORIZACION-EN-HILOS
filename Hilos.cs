using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Factorizacion
{
    class Hilos
    {
        FactNumero factNumero = new FactNumero();
        FactTrinomio factTrinomio = new FactTrinomio();
        string[] nums;
        public int c ;


        public Hilos()
        {
            leeNumTri();
            Thread h1 = new Thread(hilo1);
            Thread h2 = new Thread(hilo2);
            Thread h3 = new Thread(hilo3);
            Thread h4 = new Thread(hilo4);

            h1.Start();
            h2.Start();
            h3.Start();
            h4.Start();
        }

        public void leeNumTri()
        {
            
            //FactNumero factNumero = new FactNumero();
            //FactTrinomio factTrinomio = new FactTrinomio();
            nums = System.IO.File.ReadAllLines(@"C:\Users\yeyok\Documents\TAREAS UASLP\INTERFACES GRAFICAS\factor.txt");
            /*
            for(int i = 0; i < nums.Length; i++)
            {
                string[] valores = nums[i].Split(' ');
                int compara = int.Parse(valores[1]);
                if (compara == 0)
                {
                    int nf = int.Parse(valores[0]);
                    factNumero.factorizaNumero(nf);
                }
                else
                {
                    int na = int.Parse(valores[0]);
                    int nb = int.Parse(valores[1]);
                    int nc = int.Parse(valores[2]);
                    factTrinomio.factorizarTrinomio(na, nb, nc);

                }
            */


        }



        //HILO 1
        public void hilo1()
        {
            for (int i = 0; i < nums.Length/4 ; i++)
            {
                string[] valores = nums[i].Split(' ');
                int compara = int.Parse(valores[1]);
                if (compara == 0)
                {
                    int nf = int.Parse(valores[0]);
                    factNumero.factorizaNumero(nf);
                }
                else
                {
                    int na = int.Parse(valores[0]);
                    int nb = int.Parse(valores[1]);
                    int nc = int.Parse(valores[2]);
                    factTrinomio.factorizarTrinomio(na, nb, nc);

                }
            }
            c ++;
        }

        //HILO 2
        public void hilo2()
        {
            //(nums.Length / 3) * 2 para 3 hilos hasta nums.le/3
            for (int i = nums.Length / 4 ; i < (nums.Length / 4) * 2 ; i++)
            {
               // while (c != 1) ;
                string[] valores = nums[i].Split(' ');
                int compara = int.Parse(valores[1]);
                if (compara == 0)
                {
                    int nf = int.Parse(valores[0]);
                    factNumero.factorizaNumero(nf);
                }
                else
                {
                    int na = int.Parse(valores[0]);
                    int nb = int.Parse(valores[1]);
                    int nc = int.Parse(valores[2]);
                    factTrinomio.factorizarTrinomio(na, nb, nc);

                }
            }
            c ++;
        }


        //HILO3
        public void hilo3()
        {
            for (int i = (nums.Length / 4) * 2; i < (nums.Length/4)*3; i++)
            {
               // while (c != 2) ;
                string[] valores = nums[i].Split(' ');
                int compara = int.Parse(valores[1]);
                if (compara == 0)
                {
                    int nf = int.Parse(valores[0]);
                    factNumero.factorizaNumero(nf);
                }
                else
                {
                    int na = int.Parse(valores[0]);
                    int nb = int.Parse(valores[1]);
                    int nc = int.Parse(valores[2]);
                    factTrinomio.factorizarTrinomio(na, nb, nc);

                }
            }
            c++;
        }

        public void hilo4()
        {
            for (int i = (nums.Length/4)*3; i < nums.Length ; i++)
            {
                //while (c != 3) ;
                string[] valores = nums[i].Split(' ');
                int compara = int.Parse(valores[1]);
                if (compara == 0)
                {
                    int nf = int.Parse(valores[0]);
                    factNumero.factorizaNumero(nf);
                }
                else
                {
                    int na = int.Parse(valores[0]);
                    int nb = int.Parse(valores[1]);
                    int nc = int.Parse(valores[2]);
                    factTrinomio.factorizarTrinomio(na, nb, nc);

                }
            }
            c++;
        }



    }
}
