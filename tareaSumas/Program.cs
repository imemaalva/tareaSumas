using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaSumas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime inicio = DateTime.Now;
            Class1 suma = new Class1();
            while (suma.salida != 25) { }
            Console.WriteLine("Terminado");
            DateTime fin = DateTime.Now;
            int tiempo = fin.Millisecond - inicio.Millisecond;
            Console.WriteLine(tiempo);
            Console.ReadKey();
        }
    }
}
