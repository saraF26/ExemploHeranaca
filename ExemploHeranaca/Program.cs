namespace ExemploHeranaca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario("Luis", 45, "Barcelos");
            Funcionario f2 = new Funcionario("Pedro", 24, "Braga");

            Socio socio1 = new Socio("Manuel", 35, "VilaVerde", 100);
            Socio socio2 = new Socio("carolina", 38, "Braga", 200);

            f1.ExibirInformãcoes();
            socio1.ExibirInformãcoes();
            socio2.MostrarQtAcoes();


            
        }
    }
}
