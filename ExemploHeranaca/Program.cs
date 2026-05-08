namespace ExemploHeranaca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> listaFuncionario = new List<Funcionario>();

            Funcionario f1 = new Funcionario("Luis", 45, "Barcelos");
            Funcionario socio = new Socio("Pedro", 34, "Braga", 100);
            Funcionario tarefeiro = new Outsoursing("sara", 25, "Braga", 20);

            //adiconar á lista

            listaFuncionario.Add(f1);
            listaFuncionario.Add(socio);
            listaFuncionario.Add(tarefeiro);

            foreach(Funcionario f in listaFuncionario)
            {
                f.ExibirInformãcoes();
            }

            Socio s = new Socio("asd", 34, "brg", 500);
            listaFuncionario.Add(s);
            
            foreach (Funcionario f in listaFuncionario)
            {
                f.ExibirInformãcoes();
            }
        }
    }
}
