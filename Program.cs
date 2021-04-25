using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManejandoString
{
    class Program
    {
        static void Main(string[] args)
        { 
            ProcuraString();

            FinalDeMetodo();
            Console.ReadLine();
        }
        public static void FinalDeMetodo()// Layout padrão para final de método.
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
        }

        public static void ProcuraChar()// Pesquisar o índice de 'a' e retornar os valores após esse índice.
        {
            string url = "https://cursos.alura.com.br/course/csharp-string-regex-object/task/42360";
            int indiceA;
            string charProcurado;

            indiceA = url.IndexOf('a');
            charProcurado = url.Substring(indiceA);

            Console.WriteLine($"O dígito 'a' esta na posição do íncide: {indiceA}");
            Console.WriteLine(charProcurado);
        }

        public static void ProcuraString()// Pesquisar "alura" na url completa, retornar o indice, retornar o comprimento e retornar apenas "alura"
        {
            string url = "https://cursos.alura.com.br/course/csharp-string-regex-object/task/42360";
            string alura = "alura";
            int comprimentoAlura;
            int indiceAlura;
            string stringProcurada;

            indiceAlura = url.IndexOf(alura);
            comprimentoAlura = alura.Length;
            stringProcurada = url.Substring(indiceAlura);

            Console.WriteLine($"{nameof(url)} completa: {url}");
            Console.WriteLine($"string procurada: {nameof(alura)}");
            Console.WriteLine($"A string procurada esta na posição do índice {indiceAlura}");
            Console.WriteLine($"O comprimento da string {nameof(alura)} é de {comprimentoAlura}");
            Console.WriteLine($"string encontrada: {stringProcurada.Remove(alura.Length)}");
        }

        public static void TestarNullOrEmpty() // Verificar se minha string é Null or Empty
        {
            string url = "https://cursos.alura.com.br/course/csharp-string-regex-object/task/42360";
            bool testeNullOrEmpty;

            testeNullOrEmpty = string.IsNullOrEmpty(url);
            if (testeNullOrEmpty == false)
            {
                Console.WriteLine($"A string {nameof(url)} contém valores");
            }
            else
            {
                Console.WriteLine($"A string {nameof(url)} é null");
            }
        }

        public static void SubstituirValores() //Substituir um valor pelo outro na url principal
        {
            string url = "https://cursos.alura.com.br/course/csharp-string-regex-object/task/42360";
            string valorSubstituir = ".com";
            string valorOriginal = ".com.br";
            string urlNova;

            urlNova = url.Replace(valorOriginal, valorSubstituir);
            Console.WriteLine($"URL original: {url}");
            Console.WriteLine();
            Console.WriteLine($"O valor {valorOriginal} deve ser trocado para o valor {valorSubstituir} ");
            Console.WriteLine($"URL nova: {urlNova}");
        }

        public static void ContemValores() //Encontar uma string que começa ou termina com um valor, não importa o formato de letra (maiúsclo ou minúsculo)
        {
            string url = "https://cursos.alura.com.br/course/csharp-string-regex-object/task/42360";
            bool comecaCom;
            bool terminaCom;
            bool contemValor;
            string urlMa;
            string valorProcurado;
            string valorProcuradoMa;

            Console.WriteLine($"URL original: {url}");
            Console.WriteLine();
            Console.WriteLine($"Qual valor deseja pesqusiar na {nameof(url)} ?");
            valorProcurado = Console.ReadLine();
            valorProcuradoMa = valorProcurado.ToUpper();

            urlMa = url.ToUpper();

            comecaCom = urlMa.StartsWith(valorProcuradoMa);
            terminaCom = urlMa.EndsWith(valorProcuradoMa);
            contemValor = urlMa.Contains(valorProcuradoMa);

            Console.WriteLine($"O valor procurado {valorProcurado} esta no começo da url: {comecaCom}");
            Console.WriteLine();
            Console.WriteLine($"O valor procurado {valorProcurado} esta no fim da url: {terminaCom}");
            Console.WriteLine();
            Console.WriteLine($"O valor procurado {valorProcurado} esta no meio da url: {contemValor}");
            Console.WriteLine();
        }

        public static void ProcurandoInformacaoEspecifica() //Procurar uma informação específica, retornar true / false.
        {
            string informacaoContato = "Nome: João Silveira, Telefone: 95141-5681, e-mail: jsilva@jsilva.com.br";
            string informacaoProcurada = "@";
            bool contemInformacao;

            contemInformacao = Regex.IsMatch(informacaoContato, informacaoProcurada);

            Console.WriteLine($"Texto Completo: {informacaoContato}");
            Console.WriteLine();
            Console.WriteLine($"Texto Procurado: {informacaoProcurada}");
            Console.WriteLine();
            Console.WriteLine($"Infomaração encontrada: {contemInformacao}");
        }

        public static void ProcurandoPadrao() //Procura um padrao específico de informação em uma string.
        {
            string informacaoContato = "Nome: João Silveira, Telefone: 95141-5681, e-mail: jsilva@jsilva.com.br";
            string padraoProcurado = "[0-9]{4,5}[- ?][0-9]{4}";
            Match informacaoEncontrada;

            informacaoEncontrada = Regex.Match(informacaoContato, padraoProcurado);

            Console.WriteLine($"Texto original: {informacaoContato}");
            Console.WriteLine($"Padrão procurado: {padraoProcurado}");
            Console.WriteLine($"Valor encontrado: {informacaoEncontrada}");
        }
    }
}
