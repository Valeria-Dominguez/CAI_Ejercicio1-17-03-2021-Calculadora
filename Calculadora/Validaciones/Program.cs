using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Validaciones
{
  public static class Validaciones
    {
        public static string PedirStrNoVac(string mensaje)
        {
            string valor;
            do
            {
                Console.WriteLine(mensaje);
                valor = Console.ReadLine().ToUpper();
                if (valor == "")
                {
                    Console.WriteLine("El campo no puede estar vacío");
                }
            }
            while (valor == "");
            return valor;
        }

        public static decimal PedirNum(string mensaje)
        {
            decimal valor;
            do
            {
                Console.WriteLine(mensaje);
                if (!Decimal.TryParse(Console.ReadLine(), out valor))
                {
                    valor = -1;
                }
                if (valor == -1)
                {
                    Console.WriteLine("Debe ingresar un número decimal");
                }
            }
            while (valor == -1);
            return valor;
        }
    }    
}
