Console.WriteLine("1- Digite a temperatura em graus Celsius:");
int temperatura = Convert.ToInt32(Console.ReadLine());
bool frio = temperatura < 15;
if (frio)
{
    Console.Write("Hoje esta frio!");
}
else
{
    Console.Write("Hoje esta agradavel!");
}
Console.WriteLine("\n");

Console.WriteLine("2- digite um numero:");
int numero = Convert.ToInt32(Console.ReadLine());
bool NumeroMaior = numero > 100;
if (NumeroMaior)
{
    Console.Write("O numero e maior que cem");
}
else
{
    Console.Write("O numero e menor ou igual a cem");
}
Console.WriteLine("\n");

Console.WriteLine("3- Insira uma senha:");
string senha = Console.ReadLine();
bool senhaCorreta = (senha == "123");
if (senhaCorreta)
{
    Console.Write("a senha e igual");
}
else
{
    Console.Write("a senha nao e igual");
}
Console.WriteLine("\n");

Console.Write("4- Digite um numero: ");
int numero4 = Convert.ToInt32(Console.ReadLine());
bool numeroIn = (numero4 < 0);
if (numeroIn)
{
    Console.Write("Numero Invalido");
}
else
{
    Console.Write("Numero valido");
}
Console.WriteLine("");

Console.Write("Digite a idade de uma pessoa: ");
int idade = Convert.ToInt32(Console.ReadLine());
string resultado = (idade >= 16) ? "Cadastro permitido" : "Cadastro não permitido";
Console.WriteLine(resultado);

Console.WriteLine("");

int turno = int.Parse(Console.ReadLine());
switch (turno)
{
    case 1:
        Console.WriteLine("Manha");
        break;
    case 2:
        Console.WriteLine("Tarde");
        break;
    case 3:
        Console.WriteLine("Noite");
        break;
}