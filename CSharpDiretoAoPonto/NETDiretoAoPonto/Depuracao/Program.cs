using System;

namespace Depuracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Debugging

            //var numerosString = Console.ReadLine();
            //var numeros = numerosString.Split(' ');

            //foreach (var numero in numeros)
            //{
            //    var numeroInt = int.Parse(numero);

            //    var aoQuadrado = Math.Pow(numeroInt, 2);

            //    Console.WriteLine($"{numeroInt}² = {aoQuadrado}");
            //}


            #endregion

            #region Tratando Exceções

            var seteString = "sete";
            string valorNull = null;
            var longValue = long.MaxValue.ToString();

            try
            {
                //var formatException = int.Parse(seteString);
                var argumentNullException = int.Parse(valorNull);
                var overflowException = int.Parse(longValue);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Format Exception: {ex.Message}");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine($"Argument Null Exception: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Overflow Exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Este código é executado sempre.");
            }



            #endregion

            Console.ReadKey();

        }
    }
}
