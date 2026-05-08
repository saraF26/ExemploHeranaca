using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploHeranaca
{
    internal class Outsoursing: Funcionario
    {
        public int NumeroHoras { get; set; }

        public Outsoursing(string nome, int idade, string morada, int n_horas)
            :base(nome, idade,morada)
        {
            NumeroHoras = n_horas;
        }

        public override void ExibirInformãcoes()
        {
            base.ExibirInformãcoes();
            Console.WriteLine($"Trabalhou {NumeroHoras}");
        }
        public override string ToString()
        {
            return base.ToString() +$" nº horas {NumeroHoras}";
        }
    }
}
