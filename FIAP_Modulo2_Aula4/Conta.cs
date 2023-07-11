using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_Modulo2_Aula4
{
    abstract class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public Agencia Agencia { get; set; }
        public EStatus Status { get; set; }

        // Método abstrato, o que obriga a implementação na subclasse:
        public abstract void Depositar();

        // Método concreto, o que não obriga a implementação na subclasse:
        public double ExibeSaldo()
        {
            return 1000000.00;
        }
    }
}
