﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mysem09_1;

namespace Mysem09_1
{
    public class Class1
    {
        public void Suma()
        {
            Console.WriteLine("Ingrese un numero: ");
                int n1= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
                int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma es: " + (n1 + n2));
        }
        public void Resta()
        {
            Console.WriteLine("Ingrese un numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("la resta es: ");
                resultado = n1 - n2;
        }
    }
}
