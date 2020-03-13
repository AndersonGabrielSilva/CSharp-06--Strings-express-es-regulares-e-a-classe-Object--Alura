using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class ClasseObject_ToString_MetodoEquals
    {
        /*CLASSE OBJECT:
         Todaa classe no c# deriva da classe "object" ela é a classe MÃE de todas classes. Não precisamos fazer nenhuma classe no C# herdar dela
         a CLR já faz isto de maniera automatica.
         
        Dentro do tipo "object" existe 4 metodos:
         -GetHashCode
         -GetType
         -Equals
         -ToString
         
      /--------------------------------------------------------------------------------------------------------------------------------------------------------------
        TO STRING:
           Sintaxe: 
                            nomevariavel.ToString();

        Ele retorna uma cadeira de caracteres que representa o objeto atual. Ou melhor retorna o nome do objeto.
        O metodo ToString() é um metodo virtual. Ou seja, ele pode ser reescrito pela palavra reservada "override",
        no momento que o objeto for instanciado.
           
            Sintaxe de escrita:
                            
                            public override string ToString()
                            {
                                return "Mensagem";
                            }

       Também é possivel retornar valores pelo ToString(), adicionando as variaveis na mensagem de retorno.
       
                            public override string ToString()
                            {
                                return $"Numero {NomeVariavel}, Agência {NomeVariavel2}, Saldo {NomeVariavel3}";
                            }

      /--------------------------------------------------------------------------------------------------------------------------------------------------------------
        EQUALS:
        É um metodo que foi implementado na classe "object". Ele determina se o objeto especificado é igual ao objeto atual.
        Em sua definição tambem encontramos apalavra reservad, "Virtual", ou seja ele tambem é um metodo que pode ser sobre escrito
        pela palavra reservada "override"

            Sintaxe de escrita:

                         public override bool Equals(object obj)
                         {
                            return base.Equals(obj);
                         }

        O metodo "Equals" recebe como argumento, um objetodo tipo "object", para fazer a comparação será necessario converter
        este tipo "object" para o tipo da classe que será comparada(Classe atual).
        
        

         * */
    }
}
