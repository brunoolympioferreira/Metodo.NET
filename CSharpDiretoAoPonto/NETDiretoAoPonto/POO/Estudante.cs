using System;
using System.Collections.Generic;
using System.Linq;

namespace POO
{
    public class Estudante : Pessoa
    {
        public Estudante(string turma, string nome, string documento, DateTime dataNascimento)
            : base(nome, documento, dataNascimento)
        {
            Turma = turma;
            Notas = new List<int> { 5, 10, 4, 2, 3, 5 };
        }

        public string Turma { get; private set; }
        public List<int> Notas { get; private set; }

        public override void SeApresentar()
        {
            base.SeApresentar();

            var media = Notas.Average();

            Console.WriteLine($"Sou um estudante da turma {Turma}, Media de Nota: {media}");
        }
    }
}
