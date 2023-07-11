using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_Modulo2_Aula4
{
    enum EStatus
    {
        Ativa,
        [Description ("Aguardando Ativação da Conta")]
        Aguardando_Ativacao,
        Negativada,
        Bloqueada
    }
}
