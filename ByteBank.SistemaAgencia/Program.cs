using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.meuprimeirosite?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            //URL -> meuprimeirosite?moedaOrigem=real&moedaDestino=dolar

            //moedaOrigem=real&moedaDestino=dolar
            //|----------------|
            //Tamanho String ▲

            //ExemploLength();

            //TesteReplace();

            //Testando StartsWith, EndsWith e Contains
            //TesteStartsWitheEndsWitheContains();

            //TestandoExpressoesRegulares(); 

            // TesteToString();

            TesteEquals();

            Console.ReadLine();
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(url);

            string nomeParametro = "moedaDestino";
            string nomeParametro2 = "moedaOrigem";

            Console.WriteLine("Valor de Moeda destino: " + extratorDeValores.GetValor(nomeParametro));
            Console.WriteLine("Valor de Moeda origem: " + extratorDeValores.GetValor(nomeParametro2));
            Console.WriteLine("Valor: " + extratorDeValores.GetValor("VaLOR"));

            //TesteRemocao();

            Console.ReadLine();


        }

        static void ExemploLength()
        {
            //URL -> meuprimeirosite?moedaOrigem=real&moedaDestino=dolar

            //moedaOrigem=real&moedaDestino=dolar
            //|----------------|
            //Tamanho String ▲

            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            int indice = palavra.IndexOf("moedaDestino");
            string nomeArgumento = "moedaDestino";
            int tamanhoArgumento = nomeArgumento.Length;//Tamanho do argumento

            Console.WriteLine("\n\nString URL: " + palavra);
            Console.WriteLine("\nTamanho da String: " + palavra.Length);//Tamanho da string
            Console.WriteLine("\nIndice da string MoedaDestino: " + indice);//Indice da palavra "moedaDestino".
            Console.WriteLine("\nTamanho do Argumento: " + nomeArgumento.Length);//Tamanho da palavra "moedaDestino".
            Console.WriteLine("\nSubString: " + palavra.Substring(indice));//String apartir do indice.
            Console.WriteLine("\nString: " + palavra.Substring(indice + tamanhoArgumento + 1));//Para chegar no dolar fazemos a soma do argumento mais o seu tamanho. 
        }

        static void ExemploSubString()
        {

            // paginas? argumentos
            // 0123

            /*No CSharp a classe "String", ela é imutavel, ou seja não é possivel fazer alguma alteração.
             *Lembra os vetores no C aonde cada string é uma cadeia de caracteres aonde cada posição é um caractere 
             *que por fim acaba criando uma frase.
             * O Metodo abaixo não é permitido, justamente por conta desta caracteristica do c#*/
            
            string url = "paginas?argumentos";
            url = url.Substring(7);

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

        static void TesteRemocao()
        {
            //Vamos Remover o que tem a partir do & (E comercial)
            string testeRemocao = "primeiraParte&segundaParteRemover";

            int indiceRemocao = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao);
            Console.WriteLine(testeRemocao.Remove(indiceRemocao));
            Console.WriteLine(testeRemocao.Remove(indiceRemocao,7));

            Console.ReadLine();
            
        }   

        static void TesteReplace()
        {
            string teste = "Anderson";

            teste = teste.Replace('o', 'l');
            Console.WriteLine(teste);
        }

        //Testandoo StartsWith, EndsWith e Contains.
        static void TesteStartsWitheEndsWitheContains()
        {
            string urlTeste = "https://www.bytebank.com/cambio";

            /* Determina se o começo desta instância de cadeia de caracteres corresponde à cadeia
             de caracteres especificada.*/
            urlTeste.StartsWith("https://www.bytebank.com/cambio");

            /*Determina se o final desta instância de cadeia de caracteres corresponde à cadeia
             de caracteres especificada.*/
            urlTeste.EndsWith("https://www.bytebank.com/cambio");

            /*Determina se o final desta instância de cadeia de caracteres corresponde à cadeia
             de caracteres especificada.
             Ou seja verifica se uma string contem outra a string espeficicada)*/
            urlTeste.Contains("");


            Console.WriteLine("Teste StartsTith: " + urlTeste.StartsWith("https://www"));
            Console.WriteLine("Teste EndsWith: " + urlTeste.EndsWith("teste"));
            Console.WriteLine("Teste Contains: " + urlTeste.Contains("bytebank"));
            Console.WriteLine(urlTeste);
        }

        static void TestandoExpressoesRegulares()
        {
            //Me ligue em  7894 - 4654.
            //Meu numero e telefone é 7894 - 4654.
            //O número 7894 - 4654 é para contato profissional.

            /*EXPRESSÃO REGULAR:
                Seria extamente o que escrevi abaixo,aonde eu passo para o compilador o padrao(Regular) que desejo encontrar em uma string.*/


            //string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //OU
            // string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //OU
            // string padrao = "[0-9]{4}[-][0-9]{4}";   
            //OU
            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";  
            //OU
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            //OU
            string padrao = "[0-9]{4,5}-?[0-9]{4}";

            string textoTeste = "O número 97894-4654 é 9245-4795 para contato profissional.";  
            

            
            Console.WriteLine(Regex.IsMatch(textoTeste, padrao));

            Match resultado = Regex.Match(textoTeste, padrao);       
           
            Console.WriteLine(resultado.Value);




        }

        static void TesteToString()
        {
            ContaCorrente contaTeste = new ContaCorrente(1244, 45879);

            //Retorna o ToStringdo objeto
            Console.WriteLine(contaTeste);
            contaTeste.Depositar(500);
            string TesteToString = contaTeste.ToString();
            Console.WriteLine(TesteToString);
        
        }

        static void TesteEquals()
        {
            Cliente contaTeste = new Cliente();

            contaTeste.Nome = "Anderson Gabriel";
            contaTeste.CPF = "456.174.294-92";
            contaTeste.Profissao = "Estagiario";

            Cliente contaTeste2 = new Cliente();

            contaTeste2.Nome = "Anderson Gabriel";
            contaTeste2.CPF = "456.174.294-92";
            contaTeste2.Profissao = "Estagiario";

            if (contaTeste.Equals(contaTeste2))
            {
                Console.WriteLine("São Iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguas!");
            }
        }
    }       
}           
            