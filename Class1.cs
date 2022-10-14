using System;

public class Class1
{
	public Class1()
	{
        int[] op1, op2, r;
        int numSumas;
        public int salida = 0;

        public Class1() { 
            Random rand = new Random();
            numSumas = 5000;
            op1 = new int[numSumas];
            op2 = new int[numSumas];
            r = new int[numSumas];
            for (int i = 0; i < numSumas; i++)
            {
                op1[i] = rand.Next(1, 51);
                op2[i] = rand.Next(1, 51);
                //Console.WriteLine("{0}, {0}", op1[i], op2[i]);
            }
            //sumaSecuencial();
            Thread c1 = new Thread(sumaConcurrente1);
            Thread c2 = new Thread(sumaConcurrente2);
            c1.Start();
            c2.Start();
        }

        public void sumaSecuencial()
        {
            for (int i = 0; i < numSumas; i++)
            {
                r[i] = op1[i] + op2[i];
            }
            salida++;
        }  

        public void sumaConcurrente1()
        {
            for (int i = 0; i < numSumas / 2; i++)
            {
                r[i] = op1[i] + op2[i];
            }
            salida++;
        }

        public void sumaConcurrente2()
        {
            for (int i = numSumas / 2 + 1; i < numSumas; i++)
            {
                r[i] = op1[i] + op2[i];
            }
            salida++;
        }
    }
}
