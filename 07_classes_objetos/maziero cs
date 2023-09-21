using System;

class ContaCorrente
{
    private string titular;
    private double saldo;

    public ContaCorrente(string titular)
    {
        this.titular = titular;
        this.saldo = 0.0;
    }

    public void ConsultarSaldo()
    {
        Console.WriteLine($"Saldo disponível na conta de {titular}: R${saldo:F2}");
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de R${valor:F2} realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("O valor do depósito deve ser maior que zero.");
        }
    }

    public void Sacar(double valor)
    {
        if (valor > 0)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R${valor:F2} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
        }
        else
        {
            Console.WriteLine("O valor do saque deve ser maior que zero.");
        }
    }
}