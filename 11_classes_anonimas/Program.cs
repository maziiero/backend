public class Program
{
    public static void Main()
    {
       var pessoa1 = new { 
        nome = "João",
         idade = 20
         };
    
       var pessoa2 = new { 
        nome = "maria",
         idade = 27
         };
         Console.WriteLine($"A pessoa 1 se chama {pessoa1.nome} e a pessoa 2 {pessoa2.nome}");

         var moto1 =  new {
            marca = Console.ReadLine(),
            modelo = Console.ReadLine(),
            ano = Console.ReadLine()
         };
         var carro2 =  new {
            marca = Console.ReadLine(),
            modelo = Console.ReadLine(),
            ano = Console.ReadLine()
         };
         Console.WriteLine($"A moto 1 se chama {moto1.marca} e o carro 2 {carro2.marca}");
     }
    }
