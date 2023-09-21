class Program
{
  public static string[] poltronas =  new string[51];
    public static void Main()
    {
      Console.Clear();
      Console.WriteLine("Bem-vindo ao SesiBus");
      Console.WriteLine("--------------------");
      Console.WriteLine("Contamos com 50 lugares disponíveis");

      Menu();
    }

    public static void Menu(){
          string opcao = "";

          do{
            Console.WriteLine("$$$$$$$$ M E N U $$$$$$$$");
            Console.WriteLine("1- Para comprar passagem");
            Console.WriteLine("2- Para poltronas disponíveis");
            Console.WriteLine("3- quantidades disponiveis");
            Console.WriteLine("4-lista passageiros");
            Console.WriteLine("0- Para fechar sistema");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao){
              case "0":
                 Console.WriteLine("Obrigado, volte sempre !!!");
            
                 System.Threading.Thread.Sleep(2000);
                 break;
              case "1":
                 ComprarPassagem(); 
                 break;
              case "2":
              PoltronasDisponiveis();
              break;
               case "3":
                 quantidadesdisponiveis(); 
                 break;
              case "4":
                 listapassageiro(); 
                 break;
              default:
                 Console.WriteLine("Opção inválida !!!");
                 break;
            }

          } while (opcao != "0");
        
    }

    public static void  ComprarPassagem(){
      Console.WriteLine("Quantas passagens deseja comprar?");
      int nrPassagens = int.Parse(Console.ReadLine());

      for (int i= 1; i <= nrPassagens; i++){
          Console.WriteLine($"Digite a poltrona da {i}ª passagem");
          int nrPltrona = int.Parse(Console.ReadLine());
          Console.WriteLine("Informe o nome do passageiro:");
          string nome = Console.ReadLine();
          MarcarPoltrona(nrPltrona, nome);
     }
    }

    public static void MarcarPoltrona(int nrPltrona, string nome){
      poltronas [nrPltrona] = nome;
    }
     public static void PoltronasDisponiveis(){
       Console.WriteLine("Lista de Proltonas disponíveis");
      for (int i = 1; i <=50; i++) {
        if(poltronas[i] == null){
        Console.WriteLine($"Nº {i}");
        }

        
      }
     }

     public static void quantidadesdisponiveis(){
      int soma = 0;
       Console.WriteLine("Lista de Proltonas disponíveis");
      for (int i = 1; i <=50; i++){ 
        if(poltronas[i] == null){
            soma++;
        }
      }
        Console.WriteLine($"quantidade disponivel{soma}");
 }
  public static void listapassageiro(){
       Console.WriteLine("lista de passageiros");
      for (int i = 1; i <=50; i++){ 
        if(poltronas[i] != null){
            Console.WriteLine($"Nº {i} - Nome: {poltronas[i]} ");
        }
      }
  }
}