using System;

namespace EstruturasRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For
            Console.WriteLine("Digite uma sequência de números separados por espaço.");

            var numerosTexto = Console.ReadLine();

            var numeros = numerosTexto.Split(' ');

            Console.WriteLine("Números: ");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("Usando While: ");

            // While
            var contador = 0;

            while (contador < numeros.Length)
            {
                Console.WriteLine(numeros[contador]);
                contador++;
            }

            //ForEach
            Console.WriteLine("Usando foreach");
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
        }
    }
}
