class Programa
{
    static void Main(string[] args)
    {
        Console.Write("Digite o nome do titular da conta: ");
        string nomeTitular = Console.ReadLine();
        ContaCorrente conta = new ContaCorrente(nomeTitular);

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Consultar saldo");
            Console.WriteLine("2. Depositar");
            Console.WriteLine("3. Sacar");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    conta.ConsultarSaldo();
                    break;
                case 2:
                    Console.Write("Digite o valor para depositar: ");
                    double valorDeposito = double.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    break;
                case 3:
                    Console.Write("Digite o valor para sacar: ");
                    double valorSaque = double.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    break;
                case 4:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }

        Console.WriteLine("Programa encerrado.");
    }
}
