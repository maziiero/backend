using Models;

public class Program 
{
   public static void Main()
   {
    /*
      Pessoa Pessoa1 = new Pessoa();
      Pessoa1.nome = "Neymar";
      Pessoa1.idade = 31;

      Pessoa pessoa1 = new Pessoa {
        nome= "agnes" ,
        idade = 28
      }
    */

      Pessoa pessoa1 = new Pessoa("Neymar Junior", 31);
      pessoa1.Cantar();
      
      Pessoa pessoa1 = new Pessoa("davi paiva", 16);
      pessoa2.Cantar();
      Pessoa pessoa1 = new Pessoa("agnes maziero", 16);
      pessoa3.Cantar();

   }
}