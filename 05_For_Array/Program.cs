class Program
{
    public static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Estou passando pela {i}ª vez no bloco");
        }
        int num = 5;
        for (int cont = 1; cont <= 10; cont++)
        {
            Console.WriteLine($"{num} x {cont} = {cont * num}");
        }
        int[] notas = new int[4];

        string[] meses = { "Jan", "Fev" };


        int[] alunos = new int[6];
        alunos[4] = 3;
        alunos[5] = 11;
        alunos[3] = 7;
        alunos[0] = 20;
        alunos[2] = 8;
        alunos[1] = 12;

        int soma = 0;
        int maior = 0;
        int menor = 10000;

        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Aluno na posição {i} tem o valor {alunos[i]}");
        }

        foreach (int douglas in alunos)
        {
            soma = soma + douglas;
            if (douglas > maior)
            {
                maior = douglas;
            }
            if (douglas < menor)
            {
                menor = douglas;
            }

        }
        Console.WriteLine($"soma é {soma} o maior é {maior} e o menor é {menor}");
        Array.Sort(alunos);
        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Aluno na posição {i} tem o valor {alunos[i]}");
        }
    }
}