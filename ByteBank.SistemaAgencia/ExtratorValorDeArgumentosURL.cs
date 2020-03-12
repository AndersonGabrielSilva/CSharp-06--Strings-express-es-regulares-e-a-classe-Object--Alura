using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        /*Se a "URL", é somente leitura. Faz sentido o "_argumentos" tambem ser somente leitura. */
        private readonly string _argumentos;
        public string URL { get; }

        /*O Construtor irá separar os argumentos da URL*/
        public ExtratorValorDeArgumentosURL(string url)
        {

            /*"String.IsNullOrEmpty", Verifica se o parametro "url" é nula ou vazia. Se sim retorna "True"*/
            if (String.IsNullOrEmpty(url))
            {

                throw new ArgumentException("O argumento url não pode ser nulo ou vazio.",nameof(url));
            }


            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);

            URL = url;
        }




        //Devolverá o Valor depois do argumento. 
        public string GetValor(string nomeParametro)
        {
            //Passandotodos os argumentos para caixa alta 
            string argumentosEmCaixaAlta = _argumentos.ToUpper();
            string parametrosEmCaixaAlta = nomeParametro.ToUpper();
            
            //Colocamos o "=" pois queremos o parametro do nome do argumento mais o = pois o valoresta sempredepois de = 
            string termo = parametrosEmCaixaAlta + '=';


            /*Busca o nome do parametro nos argumentos. neste momento estão tudo em caixa alta.Ao
            encontrar ele devolve o indice do nomeParametro*/
            int indiceTermo = argumentosEmCaixaAlta.IndexOf(termo);


            //Recebe a string a partir do indice mais o tamanho do parametro. Assim ele retorna somenteo valor 
            string resultado = _argumentos.Substring((indiceTermo + termo.Length));
            int indiceEcomercial = resultado.IndexOf('&');


            /*Quando o "IndexOf" não encontra o indice ele retorna -1*/
            if (indiceEcomercial == -1)
            {
                /*Retorna o resultado, porque o Caractere & nãofoi encontrado*/
                return resultado;
            }

            return resultado.Remove(indiceEcomercial);
        }
    }       
}
