using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mysem09_1
{
    public class Calculadora
    {
        public void Multiplicar(ref resultado)
        {
            Console.WriteLine("Ingrese un numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La multiplicacion es: ");

            resultado = n1 * n2;
        }
    }
}
