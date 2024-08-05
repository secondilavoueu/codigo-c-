using ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        // Criar uma instância da classe Carro
        Carro meuCarro = new Carro("Chevrolet", "Impala", 1967, "vermelho vinho", 100);

        // Chamar os métodos da instância
        meuCarro.ExibirInformacoes();
        meuCarro.Ligar();
    }
}