namespace Models 
{
     public class Pessoa
     {
        private string nome { get; set; }
        private int idade { get; set; }

        public Pessoa (string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }
     }
}