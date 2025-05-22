using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mysem09_1;

namespace Sem09_13126
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 xd = new class1();
            xd.sumar();
            int resultado = 0;
            resultado = 10;
            Console.WriteLine("LA resta es: "+ resultado);

            Calculadora c = new Calculadora();
            int r2;
            c.Multiplicar(out r2);
            Console.WriteLine("La multiplicacion es: " + r2);

            Console.ReadKey();

        }
    }
}
