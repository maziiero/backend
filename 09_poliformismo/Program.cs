class animal
{
    public string cor { get; set; }
     public virtual void EmitirSom()
     {
        Console.WriteLine($"Animal da cor {cor} fazendo algum som");
     }
}
class cachorro : animal
{
    public override void EmitirSom()
    {
        Console.WriteLine($"Cachorro da cor {cor} está latindo! Au au au");
    }
}
class gato : animal
{
 public override void EmitirSom()
    {
        Console.WriteLine($"Gato da cor {cor} está miando! miau miau miau");
    }

    public void Ronronar()
    {
        Console.WriteLine(o gato esta ronronando);
    }
    
}

class Program 
{
   public static void Main()
   {
     animal animalGenerico = new animal();
     animalGenerico.cor = "preto";
     animalGenerico.EmitirSoml();
     cachorro meucachorro = new cachorro();
     meucachorro.cor = "caramelo";
     meucachorro.EmitirSom();
     Gato meuGato = new Gato();
     meuGato.cor = "cinza";
     meuGato.EmitirSom();
     meuGato.Ronronar();

   }
}




