//o namaspace é um nome em que usaremos para fazer referência quando usarmos
namespace Sesi.Model
{

//declarando a classe aluno
    public class Aluno
    {
        //declarando os atributos(propriedades) da classe aluno
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }
        
        //declarando um atribuito privado
        public int nrFaltas { get; set; } 
        //criando um mértodo

        public void apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome}, eu tenho {idade} anos e estudo na turma {turma} e tenho {nrFaltas} faltas");
        }
        public void AdicionarFaltas(int nr)
        {
            Console.WriteLine($"O aluno {nome} faltou hoje e somou {nr}");
            nrFaltas = nrFaltas + nr;
            //método ResumoFaltas
        }

        public void faltas(){
            Console.WriteLine($"O aluno {nome} tem {nrFaltas} faltas");
        }
    }
}