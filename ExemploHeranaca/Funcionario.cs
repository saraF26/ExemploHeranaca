using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploHeranaca
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Morada { get; set; }

        //construtor com parametros
        public Funcionario(string nome, int idade, string morada)
        {
            Nome = nome;
            Idade = idade;
            Morada = morada;
        }
        
        //Metodo
        
        public void ExibirInformãcoes()
        {
            Console.WriteLine($"Funcionario: {Nome}, idade: {Idade}, morada: {Morada}");
        }
        

    }
}
