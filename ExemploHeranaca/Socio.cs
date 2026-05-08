using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploHeranaca
{
    internal class Socio : Funcionario
    {
        public int NumeroAcoes { get; set; }

        //construtor

        public Socio(string nome, int idade, string morada, int n_acoes)
            :base( nome,idade,morada)
        {
            NumeroAcoes = n_acoes; 
        }

        //metodo
        public void MostrarQtAcoes()
        {
            Console.WriteLine($"O numero de acçõs é {NumeroAcoes}");
        }
    }
}
