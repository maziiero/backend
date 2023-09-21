namespace Sesi.Models
{
    public class animal
    {
        
        public string cor { get; set; }

        public decimal especie { get; set; }

        public decimal peso { get; set; }
    }

    public void EmitirSom(){
        Console.WriteLine("Emitindo Som");
    }
}