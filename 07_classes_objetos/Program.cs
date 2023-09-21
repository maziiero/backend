using Sesi.Model;

class program
{
    public static void Main ()
    {
       var aluno1 = new Aluno();
       aluno1.nome = "Agnes";
       aluno1.idade  = 16;
       aluno1.turma = "2º EM";
       aluno1.nrFaltas = 0;

       //chamando o método da classe aluno 
       aluno1.apresentar();

       var aluno2 = new Aluno();
       aluno2.nome = "julia";
       aluno2.idade  = 17;
       aluno2.turma = "2º EM";

       aluno2.apresentar();
       aluno2.AdicionarFaltas(10);
       aluno2.faltas();

       //Chamar método  ResumoFaltas
    }
}
