  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    internal class AutenticacaoHelper
    {/*Esta classe ela somente auxilia outra classe. Por isto porconvenção se coloca o nome sufixo "Helper"*/
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)//Pega 2 strings
        {
            return senhaVerdadeira == senhaTentativa;//retorna a verificação destas senhas
        }        
    }
}
