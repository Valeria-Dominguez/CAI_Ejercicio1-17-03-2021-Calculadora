using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Operaciones
{
    public static class Operaciones
    {
        public static void Sumar(decimal valor1, decimal valor2)
        {
            decimal resultado = 0;
            resultado = valor1 + valor2;
            Console.WriteLine("\nEl resultado es " + resultado + "\n");
        }

        public static void Restar (decimal valor1, decimal valor2)
        {
            decimal resultado = 0;
            resultado = valor1 - valor2;
            Console.WriteLine("\nEl resultado es " + resultado + "\n");
        }

        public static void Multiplicar (decimal valor1, decimal valor2)
        {
            decimal resultado = 0;
            resultado = valor1 * valor2;
            Console.WriteLine("\nEl resultado es " + resultado + "\n");
        }

        public static void Dividir (decimal valor1, decimal valor2)
        {
            decimal resultado = 0;
            if (valor2 == 0)
            {
                Console.WriteLine("\nNo es posible dividir por cero\n");
            }
            else
            {
                resultado = valor1 / valor2;
                Console.WriteLine("\nEl resultado es " + resultado + "\n");
            }
        }
    }
}
