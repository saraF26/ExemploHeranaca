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
        
        //adiconar a palavra virtual ao metodo para que este possa ser redefinido
        //pelas classes derivadas
        public virtual void ExibirInformãcoes()
        {
            Console.WriteLine($"Funcionario: {Nome}, idade: {Idade}, morada: {Morada}");
        }
        //public virtual void MostrarQtAcoes()
        //{
        //    Console.WriteLine("Este funcionario não tem ações");
        //}
        public override string ToString()
        {
            return $"Funcionario: {Nome}, idade: {Idade}";
        }


    }
}
