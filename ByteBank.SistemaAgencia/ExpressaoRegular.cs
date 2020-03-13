using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class ExpressaoRegular
    {

        /*EXPRESSÃO REGULAR: 
            É uma expressão que, o programador escreve que define uma regularidade (padrão), que habita dentro de uma string.
            Com ela realizamos buscas rapidas, e precisas em algum texto, seja htlm, txt, excel e etc. 
            
        Seria exatamente como ocodigo que esta escrito abaixo aonde passamos para o "Motor do Regex" a regularidade que desejamos encontrar.

        Numero telefone: 9845-4597
        
        EXEMPLOS:
            
                    string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
        
        Os "[]" simbolisa os caracteres que desejamos buscar aonde dentro deles, se encontra o caractere ou a sequencia de caractere que pode haver neste indice
        no exemplo a cima estamos realizando a busca de um numero de telefone aonde estamos passando para o "Regex" que em cada indice de caractera pode haver um 
        numero de [0-9](De Zero a Nove). Apos de repetir 4 vezes havera um caractere que será o [-](Traço) e depois mais quatro caracteres de [0-9](De Zero a Nove) 
    
      /--------------------------------------------------------------------------------------------------------------------------------------------------------------
        Podemos simplificar um pouco mais ▼
    
                    string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
        
        Quando colocamos o "-" estamos falando que é de 0 a 9, os caracteres que poderão estar ali.

      /--------------------------------------------------------------------------------------------------------------------------------------------------------------
        Podemos simplificar um pouco mais com quantificadores ▼
        
                    string padrao = "[0-9]{4}[-][0-9]{4}";
                    
        Quando ultilizamos o "{x}" queremos diser que este modelo de caractere se repete "x" vezes, neste caso a cima por exemplo estamos queredo diser,
        que o padrao de caractere numero de 0 a 9 se repete 4 vezes.

      /--------------------------------------------------------------------------------------------------------------------------------------------------------------
        Podemos deixar ainda mais flexivel, nosso "Regex"▼

                   string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";  

        Ao coloar a "," no campo dos quantidadores, estamos querendo diser que "os caracteres podem variar de {x,y} (x a y) em quantidade, como no exemplo a
        cima estamos querendo diser que os primeiros caracteres podem varias de 4 a 5(caracteres). 

      /--------------------------------------------------------------------------------------------------------------------------------------------------------------
        Podemos ultilizar quantificadores para infomar ao "Motor do Regex" que aquele caracterepode ou não estar presente▼

                   string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
        
        Ao colocar no {0,1} estamos informando que este caracterepode pode (1) ou não (0) estar presente. Como no exemplo acima hápessoas que colocam o traco "-"
        e pessoas que não. 

      /--------------------------------------------------------------------------------------------------------------------------------------------------------------
      Podemos deixar ainda mais simples nossa expressão regular (Regex) ultilizando o quantificador "?"▼

                   string padrao = "[0-9]{4,5}-?[0-9]{4}";

        O "?"é ultilizado no lugar do [0,1]. Estamos querendo informar ao "Motor do Regex" que o caractere pode ou não estar preente.

      /--------------------------------------------------------------------------------------------------------------------------------------------------------------
      */

    }
}
