using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            // paginas? argumentos
            // 0123

            /*No CSharp a classe "String", ela é imutavel, ou seja não é possivel fazer alguma alteração.
             *Lembra os vetores no C aonde cada string é uma cadeia de caracteres aonde cada posição é um caractere 
             *que por fim acaba criando uma frase.
             * O Metodo abaixo não é permitido, justamente por conta desta caracteristica do c#*/
            //url = url.Substring(7);

            string url = "paginas?argumentos";
            Console.WriteLine(url);

            /*Ao fazer a operação abaixo,o que na verdade acontece é que por baixo dos panos o C# cria uma string Temporaria aonde 
             ela recebe os caracteres da string url somados com os caracteres da string "Anderson". 
             *E depois de receber os valores,  compilador simplesmente altera a referencia (O endereço na memoria)*/
            url += " Anderson";
            Console.WriteLine(url);


            string url2;
            url2=url.Substring(7);            
            Console.WriteLine(url2);

            Console.ReadLine();

        }
    }
}
