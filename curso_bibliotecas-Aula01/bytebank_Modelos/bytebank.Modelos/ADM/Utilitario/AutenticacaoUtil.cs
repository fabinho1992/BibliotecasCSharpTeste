using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_Modelos.bytebank.Modelos.ADM.Utilitario
{
    public  class AutenticacaoUtil// COM O INTERNAL , A CLASSE SÓ É VISIVEL E SÓ PODE SER USADA DENTRO DA PRÓPRIA BIBLIOTECA
    {
        public  bool ValidarSenha(string senhaCriada, string senhaSistema )
        {
            return senhaCriada.Equals( senhaSistema );// aqui comparo a senha do usuario com a senha que ja está em sistema
        }
    }
}
