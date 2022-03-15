using System;

namespace CsharpDiretoAoPontoHelloWorld
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tipos de Dados

            int numeroInt = 10;

            int maiorNumeroInt = int.MaxValue;
            int menorNumeroInt = int.MinValue;

            long numeroLong = 1212121212121212312;

            long maiorNumeroLong = long.MaxValue;
            long menorNumeroLong = long.MinValue;

            decimal numeroDecimal = 10.52m;

            double numeroDouble = 12.3;
            double menorNumeroDouble = double.MinValue;

            bool verdadeiro = true;
            bool falso = false;

            var numero = 10;

            string nome = "Bruno Ferreira";
            char letra = 'B';

            DateTime entradaEmpresa = new DateTime(2021,1,1);
            TimeSpan quantoTempoDeEmpresa = DateTime.Now - entradaEmpresa;

            #endregion

            #region Conversões
            //Conversao Implicita
            int notaAluno = 10;
            double notaAlunoDouble = notaAluno;

            //Conversao Explicita
            int numeroDoubleComoInt = (int) notaAlunoDouble;


            //Conversao utilizando Convert
            string notaString = "10";
            int notaConvert = Convert.ToInt32(notaString);

            // Conversao utilizando Parse
            int notaParse = int.Parse(notaString);

            if (int.TryParse(notaString, out int notaTryParse))
            {

            } else
            {
                Console.WriteLine("Número em formato inválido");
            }
            #endregion

            #region Operadores Aritméticos

            // Unários ++, - -. + e -

            int numeroOperador = 4;

            Console.WriteLine(numeroOperador++); // 4
            Console.WriteLine(numeroOperador--); // 5

            Console.WriteLine(++numeroOperador); // 5
            Console.WriteLine(--numeroOperador); // 4

            Console.WriteLine(numeroOperador);
            Console.WriteLine(-numeroOperador);
            Console.WriteLine(-(-numeroOperador));

            // Binários * / + -
            var soma = 4 + 5;
            var subtracao = 4 - 5;
            var multiplicacao = 20 / 3;
            var divisaoDouble = (double)20 / 3;

            var multiplos = (4 * 5) + 10;

            #endregion

            #region Operadores de Comparação

            Console.WriteLine( 4 > 5);
            Console.WriteLine( 5 > 5);
            Console.WriteLine( 5 >= 5);

            Console.WriteLine(5 < 4);
            Console.WriteLine(5 <= 5);
            Console.WriteLine(5 < 6);


            #endregion

            #region Operadores de Igualdade ==, !=

            Console.WriteLine(5 == 5);
            Console.WriteLine(5 == 4);

            Console.WriteLine(5 != 5);
            Console.WriteLine(4 != 5);

            #endregion

            #region Operadores Lógicos AND && e OR ||

            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);

            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            #endregion

            Console.Read();
        }
    }
}
