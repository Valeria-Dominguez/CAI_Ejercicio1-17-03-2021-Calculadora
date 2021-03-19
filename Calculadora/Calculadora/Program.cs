using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Inicio
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPcipal();

            void MenuPcipal()
            {
                const string opSum = "S";
                const string opRest = "R";
                const string opMult = "M";
                const string opDiv = "D";
                const string opSal = "X";
                string opcion = "";
                decimal valor1 = 0;
                decimal valor2 = 0;
                do
                {
                    opcion = Calculadora.Validaciones.Validaciones.PedirStrNoVac("Ingrese una opción:\n"+
                        opSum + " .Sumar\n"+
                        opRest + " .Restar\n" +
                        opMult + " .Multiplicar\n" +
                        opDiv + " .Dividir\n" +
                        opSal + " .Salir\n"
                        );

                    if (opcion == opSum || opcion == opRest || opcion == opMult || opcion == opDiv)
                    {
                        valor1= Calculadora.Validaciones.Validaciones.PedirNum("Ingrese un número");
                        valor2= Calculadora.Validaciones.Validaciones.PedirNum("Ingrese otro número");
                    }

                    switch (opcion)
                    {
                        case opSum:
                            Calculadora.Operaciones.Operaciones.Sumar(valor1, valor2);
                            break;
                        case opRest:
                            Calculadora.Operaciones.Operaciones.Restar(valor1, valor2);
                            break;
                        case opMult:
                            Calculadora.Operaciones.Operaciones.Multiplicar(valor1, valor2);
                            break;
                        case opDiv:
                            Calculadora.Operaciones.Operaciones.Dividir(valor1, valor2);
                            break;
                        default:
                            Console.WriteLine("Debe ingresar una opción válida");
                            break;
                    }
                }
                while (opcion != opSal);
            }
            
        }
    }
}
