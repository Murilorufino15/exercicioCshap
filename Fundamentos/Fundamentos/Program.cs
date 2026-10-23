Console.WriteLine("Hello, World!");

const string nome1 = "Gabriel";
Console.WriteLine(nome1);

string texto = "oi tudo bem com voce, meu nome e murilo";

string nomeCompleto = "Murilo Henrique Basseto Rufino";

Console.WriteLine(texto);
Console.WriteLine(nomeCompleto);

bool diaDeSol = true;

Console.Write("Digite seu nome: ");
string nome = Console.ReadLine(); // Lê o texto digitado

Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine()); // Lê o texto e converte para número

Console.WriteLine("Olá, " + nome + "! Você tem " + idade + " anos.");

string entrada = Console.ReadLine();
Console.WriteLine(entrada + entrada);
// String "1"
int numero1 = int.Parse(entrada);
Console.WriteLine(numero1 + entrada);

Console.WriteLine($"A soma e {numero1} + {numero1} = {numero1 + numero1}");

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
int mu = 15;
int na = 25;
Console.WriteLine(mu < na);

