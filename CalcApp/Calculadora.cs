using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp
{
    public class Calculadora
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }

        public double Adicao => Numero1 + Numero2;
        public double Subtracao => Numero1 - Numero2;
        public double Multiplicacao => Numero1 * Numero2;

        public double Divisao
        {
            get
            {
                if (Numero2 == 0)
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    return double.NaN;
                }
                return Numero1 / Numero2;
            }
        }
    }
}