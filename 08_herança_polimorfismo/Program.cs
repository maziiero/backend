using Sesi.Models;


class Program 
{
     
     public static void Main()
     {
       Gato meuGato = new Gato();
       meuGato.nome = "bichano";
       meuGato.cor = "preto";
       meuGato.idade = 2;
       meuGato.especie = "Vira lata";
       meuGato.genero = "macho";
       meuGato.peso = 3;


       Peixe meuPeixe = new Peixe();
       meuPeixe.especie = "palhaço";
       meuPeixe.cor = "laranja";
       meuPeixe.tamanho = 0.20M;
       meuPeixe.especie = 0.100m;
       
     }
}
