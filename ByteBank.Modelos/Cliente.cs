using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        /// <summary>
        /// (Metodo alterado) realiza a comparação entre dois objetos do mesmo tipo 
        /// </summary>
        /// <param name="obj">Recebe a Classe que deseja fazer a comparação</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            //Convertendo o "object" para "Cliente"
            //Cliente outroCliente = (Cliente)obj;
            
            /*A palavra reservada "as" converte o "Cliente" para o tipo object. Caso a classe informada
            seja diferente de "Cliente" o objeto "outroCliente", recebe "NULL". Desta forma é possivel tratar esta exceção. */
            Cliente outroCliente = obj as Cliente;

            if (outroCliente == null)
            {
                return false;
            }

            //return Nome==outroCliente.Nome && CPF == outroCliente.CPF && Profissao == outroCliente.Profissao;

            /*Se minha classe possui alguma propriedade indentificadora, como porexemplo a classe cliente possui o CPF. Acaba 
             não sendo nescessario a comparação de todas as propriedades, e sim apenas deste atributo identificador. como por exemplo
             o CPF. Ou na classe contacorrente posso comparar somente a "Agencia" e o "Numero" da conta.
            Exemplo: */
            return CPF == outroCliente.CPF;
        }
    }
}
