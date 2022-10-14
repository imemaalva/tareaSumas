using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace tareaSumas
{
public class Class1
{
        int[] op1, op2, r;
        int numSumas,numHilos;
        public int salida = 0;
        public Class1()
        {

            Random rand = new Random();
            numSumas = 10000;
            numHilos = 1;

            for(int k = 0; k < 5; k++)
            {
                for (int j = 0; j < 5; j++)
                {
                    op1 = new int[numSumas];
                    op2 = new int[numSumas];
                    r = new int[numSumas];

                    for (int i = 0; i < numSumas; i++)
                    {
                        op1[i] = rand.Next(1, 51);
                        op2[i] = rand.Next(1, 51);
                    }

                    Console.WriteLine("Numero de sumas: {0}", numSumas);
                   
                    if (j == 0)
                            sumaSecuencial();
 
                    Console.WriteLine();

                    Console.WriteLine("-----Inicia hilo {0} -----", numHilos);
                    var watch2 = System.Diagnostics.Stopwatch.StartNew();
                    Thread c1 = new Thread(aux);

                    c1.Start(numHilos);
                    watch2.Stop();
                    var elapsedMs2 = watch2.ElapsedMilliseconds;
                    Console.WriteLine("Tiempo: " + elapsedMs2); 
                    numHilos++;  
                }
                Console.WriteLine();
                numSumas += 10000;
                numHilos = 1;
            }
        }
        public void sumaSecuencial()
        {
            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < numSumas; i++)
            {
                r[i] = op1[i] + op2[i];
            }
           
            Console.WriteLine("Termino secuencial");
            salida++;
            watch1.Stop();
            var elapsedMs1 = watch1.ElapsedMilliseconds;
            Console.WriteLine("Tiempo: " + elapsedMs1);
        }  

        public void aux(object numHILos)
        {
            sumaConcurrente((int) numHILos);
        }

        public void sumaConcurrente(int numHILos)

        {
            for (int i = 0; i < numSumas / numHILos; i++)
            { 
                r[i] = op1[i] + op2[i];
            }

            for (int i = numSumas/numHILos + 1; i < numSumas; i++)
            {
                r[i] = op1[i] + op2[i];
            }
            salida++;
        }

       
    }
 }

