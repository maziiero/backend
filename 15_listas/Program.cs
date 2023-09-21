using System.Collections.Generic;
using Sesi.Models;
public class Program
{
    public static void Main()
    {
        List<int> listaNumeros = new List<int>();

        listaNumeros.Add(10);
        listaNumeros.Add(20);
        listaNumeros.Add(45);

        Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");
    
        Console.WriteLine(listaNumeros[1]);

        listaNumeros.Add(6);
         Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");
         Console.WriteLine("------------------------------");

           List<int> listaNumeros2 = new List<int>();
            listaNumeros2.Add(10); 
            listaNumeros2.Add(3);
            listaNumeros2.Add(4);

     
    
            Console.WriteLine(listaNumeros2[1]);

            listaNumeros2.Add(80);
            Console.WriteLine($"neste momento temos {listaNumeros.Count} nrs");



        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9};

        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

        numeros.Remove(2);
        numeros.RemoveAt(4);
        numeros.RemoveRange(2, 2);

        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

        List<Aluno> listaAlunos = new List<Aluno>();

        Aluno novoAluno =  new Aluno("Agnes", 16);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("julião", 17));
        listaAlunos.Add(new Aluno("luana", 16));

        Console.WriteLine("Lista de Alunos:");
        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine($"Nome aluno: {item.nome}");
        }

        var consulta = listaAlunos
                        .Where (aluno =>aluno.idade > 18)
                        .OrderBy ( aluno =>aluno.nome);
       Console.WriteLine("Lista de alunos maiores de 18 anos");
       foreach (var item in consulta)
       {
        Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");
       }
        var metodo = listaAlunos
                    .Where(Aluno => Aluno.idade <18)
                    .OrderBy(Aluno => Aluno.nome);
        Console.WriteLine("Lista de alunos menores de 18 anos");

     foreach (var item in metodo)
       {
        Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");
       }               
       
     
    }

    }
