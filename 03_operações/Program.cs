Console.WriteLine("Digite o valor de X:");
//precisamos converter os dados que recebemos do ReadLine
//int.Parse() para converter para inteiro
int x = int.parse(console.ReadLine());
console.WriteLine("Digite o valor de y:");
int y = int.Parse(Console.ReadLine());

//exemplos de operadores aritméticos
int soma = x + y;
int subtracao = x- y;
int mutiplicacao = x * y;
int divisao = x / y;
int resto = x % y;


Console.WriteLine("Soma: " + soma);
Console.WriteLine("Subtração: " + subtracao);
Console.WriteLine("Multiplicação: " + mutiplicacao);
Console.WriteLine("Divisão: " + divisao);
Console.WriteLine("Resto: " + resto);

if(restoDiv2 == 0){
    console.WriteLine($"{x} é par");
} else {
    console.WriteLine($"{x} é ímpar");
}

//operador ternário
//condição ? se verdade : senão
 string ePar = (restoDiv2 == 0)  ? "par" : "ímpar";
