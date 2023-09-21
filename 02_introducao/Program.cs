// Somente declararmos a variável como inteira e não atribuirmos valor
int numl;

//declarando uma variável do tipo inteira e atribuindo o valor 5 
int num2 = 5;

//declarando uma variável do tipo string 
string nomeAluno;

//variável do tipo lógico (verdadeiro ou falso)
bool resultado = true;

//variável do tipo com casas decimais - para valores mais precisos 
double coordenada = 1.80;

//variável do tipo decimal - mais usada para valor monetário
decimal valor = 1.80m;



int idade = 16;
string nome = "agnes maziero";
Console.WriteLine($"oii,me chamo {nome} e tenho {idade} anos");

Console.WriteLine("em que cidade você nasceu?");
//recebendo uma informação do usuário e atribuindo na variável cidade
string cidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {cidade}");


int novaIdade = idade + 5;
int anoNascimento = 2023 - idade;
Console.WriteLine($"você nasceu em {anoNascimento} e daqui 5 anos terá {novaIdade}");