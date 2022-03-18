using System;

namespace TrabalhandoComStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Principais metodos, Campo e Propriedade
            var paragrafo = "    C# é uma linguagem moderna e versátil." +
                            "Com C# consigo desenvolver para web, Desktop, Jogos, " +
                            "Mobile, entre outros. ";

            //Lenght
            var tamanho = paragrafo.Length;

            // Empty
            var vazio = string.Empty;

            //ToLower, TuUpper
            var paragrafoMinusculo = paragrafo.ToLower();
            var paragrafoMaiusculo = paragrafo.ToUpper();

            //Split
            var frases = paragrafo.Split('.');

            //Trim, TrimEnd, TrimStart
            var paragrafoTrim = paragrafo.Trim();
            var paragrafoTrimEnd = paragrafo.TrimEnd();
            var paragrafoTrimStart = paragrafo.TrimStart();

            //IsNullOrWhitespace
            var isNullOrWhitespace = string.IsNullOrWhiteSpace(paragrafo);

            //Replace
            var paragrafoCsharp = paragrafo.Replace("C#", "C-sharp");
            #endregion

            #region Busca
            var outroParagrafo = "C# é uma linguagem moderna e versátil." +
                     "Com C# consigo desenvolver para Web, Desktop, Jogos, " +
                     "Mobile, entre outros.";

            // IndexOf
            var indexOf = outroParagrafo.IndexOf("C#");

            //LastIndexOf
            var lastIndexOf = outroParagrafo.LastIndexOf("C#");

            //StartWith
            var startWith = outroParagrafo.StartsWith("C#");

            //Substring
            var indexOfMobile = outroParagrafo.IndexOf("Mobile");
            var substringMobile = outroParagrafo.Substring(indexOfMobile, 6);

            //Contains
            var containsJogos = outroParagrafo.Contains("jogos", StringComparison.OrdinalIgnoreCase);
            var containsJogosExact = outroParagrafo.Contains("Jogos");
            var containsRuim = outroParagrafo.Contains("ruim");

            #endregion

            Console.ReadKey();
        }
    }
}
