using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_Modulo2_Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPessoaFisica contaFisica = new ContaPessoaFisica();
            Console.WriteLine($"Saldo: R$ {contaFisica.ExibeSaldo()}");
            //Console.ReadKey();

            //contaFisica.Status = EStatus.Ativa;

            contaFisica.Status = EStatus.Aguardando_Ativacao;
            //Console.WriteLine(contaFisica.Status.GetType().GetField(contaFisica.Status.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[]);
            var attributeDescription = contaFisica.Status.GetType().GetField(contaFisica.Status.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
            var descricao = attributeDescription[0].Description;
            Console.WriteLine(descricao);
            Console.ReadKey();

            // if (contaFisica.Status.Equals(EStatus.Ativa)) { ... }
        }
    }
}
