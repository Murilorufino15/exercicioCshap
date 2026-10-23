// OBRIGATORIOS
Console.WriteLine("Exercicios Obrigatorios:");
Console.WriteLine();

int velocidade1 = 30;
int dias1 = 16;
int velocidade2 = 20;
int distancia = velocidade1 * dias1;
int dias2 = distancia / velocidade2;
int espera = dias2 - dias1;
Console.Write($"O tempo de espera foi de: {espera}");
Console.WriteLine();
Console.WriteLine();

int cartas = 52;
int cartasUsadas = 1 + 2 + 3 + 4 + 5 + 6 + 7;
int cartasSobrando = cartas - cartasUsadas;
Console.Write($"O numero de cartas sobrando e de: {cartasSobrando}");
Console.WriteLine();
Console.WriteLine();

int sabores = 3;
int borda = 2;
int tamanho = 2;
int combinacoes = sabores * borda  + tamanho;
Console.WriteLine($"A quantidade de combinacoes possiveis e de: {combinacoes} ");
Console.WriteLine();
Console.WriteLine();

int[] sequencia1 = { 1, 3, 5, 7 };
int proximo1 = sequencia1[^1] + 2;
Console.WriteLine($"I)Proximo: {proximo1}");

int[] sequencia2 = { 2, 4, 8, 16, 32, 64 };
int proximo2 = sequencia2[^1] * 2;
Console.WriteLine($"II)Proximo: {proximo2}");

int[] sequencia3 = { 0, 1, 4, 9, 16, 25, 36 };
int ultimoNumero = sequencia3[^1];
int raiz = (int)Math.Sqrt(ultimoNumero);
int proximoNumero = raiz + 1;
int proximo3 = proximoNumero * proximoNumero;
Console.WriteLine($"III)Proximo: {proximo3}");

int[] sequencia4 = { 4, 16, 36, 64 };
int ultimoNumeroPar = sequencia4[^1];
int raizPar = (int)Math.Sqrt(ultimoNumeroPar);
int prozRaizPar = raizPar + 2;
int proximo4 = prozRaizPar * prozRaizPar;
Console.WriteLine($"IV)Proximo: {proximo4}");

int[] sequencia5 = { 1, 1, 2, 3, 5, 8 };
int proximo5 =  sequencia5[^1] + sequencia5[^2];
Console.WriteLine($"V)Proximo: {proximo5}");
Console.WriteLine();

///////////////////////////////////////////////////
Console.WriteLine("Exercicios faceis:");

Console.Write("1 - Digite um numero:");
int numero1 = int.Parse(Console.ReadLine());
int dobro1 = numero1 * 2;
Console.Write($"O dobro do numero e: {dobro1}");
Console.WriteLine();
Console.WriteLine();

Console.Write("2 - Digite um numero:");
int numero2 = int.Parse(Console.ReadLine());
Console.Write("2 - Digite outro numero:");
int numero22 = int.Parse(Console.ReadLine());
int soma = numero2 + numero22;
Console.Write($"A soma do numero e: {soma}");
Console.WriteLine();
Console.WriteLine();

Console.Write("3 - Digite um numero:");
int numero = Convert.ToInt32(Console.ReadLine());
bool ehPar = (numero % 2 == 0);
if (ehPar)
{
    Console.WriteLine($"O número {numero} é PAR.");
}
else
{
    Console.WriteLine($"O número {numero} é ÍMPAR.");
}
Console.WriteLine();
Console.WriteLine();

Console.Write("4 - Digite um numero:");
int numero4 = Convert.ToInt32(Console.ReadLine());
Console.Write("4 - Digite outro numero:");
int numero44 = Convert.ToInt32(Console.ReadLine());
bool numero1Maior = numero4 > numero44;
if (numero1Maior)
{
    Console.Write($"O maior numero e: {numero4}");
}else
{
    Console.Write($"O maior numero e: {numero44}");
}
Console.WriteLine();
Console.WriteLine();

Console.Write("5 - Insira sua idade:");
int idade = Convert.ToInt32(Console.ReadLine());
bool maiorDeIdade = idade > 18;
if(maiorDeIdade)
{
    Console.Write("Voce e maior de idade");
}else
{
    Console.Write("Voce e menor de idade");
}
///////////////////////////////////////////////////////
Console.WriteLine("Exercicios medios:");
Console.WriteLine("1 - Insira a primeira nota:");
int nota1 = Convert.ToInt32(Console.ReadLine());
Console.Write("1 - Insira a segunda nota:");
int nota2 = Convert.ToInt32(Console.ReadLine());
bool aprovado = (nota1 + nota2) / 2 >= 6;
if (aprovado)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.Write("Reprovado");
}
Console.WriteLine();


Console.WriteLine("2 - Insira um numero:");
int numero5  = Convert.ToInt32(Console.ReadLine());
bool estaInter = numero5 >= 50 && numero5 <= 100;
if (estaInter)
{
    Console.Write($"O numero {numero5} esta entre 50 e 100");
}
else
{
    Console.Write($"O numero {numero5} nao esta entre 50 e 100");
}
Console.WriteLine();


Console.WriteLine("3 - Insira o valor de um produto:");
int valor3 = Convert.ToInt32(Console.ReadLine());
bool temDesconto = valor3 >= 100;
double desconto = valor3 * 0.10;
if (temDesconto)
{
    Console.Write($"O valor do produto com desconto saira de {valor3} para {desconto + valor3}");
}
else
{
    Console.Write($"O valor permanecera de {valor3}");
}
Console.WriteLine();


Console.Write("4 - Digite um numero:");
double numero6 = Convert.ToDouble(Console.ReadLine());
bool positivo = numero6 > 0;
bool negativo = numero6 < 0;
if (positivo)
{
    Console.Write("Este numero e positivo");
}
else if (negativo)
{
    Console.Write("Este numero e negativo");
}
else
{
    Console.Write("Este numero e zero(0)");
}
Console.WriteLine();


Console.Write("5 - Insira sua idade:");
int idade13 = Convert.ToInt32(Console.ReadLine());
bool podVotar = idade >= 18;
if (podVotar)
{
    Console.Write("Voce pode votar, faz o L");
}
else
{
    Console.Write("Voce nao pode votar");
}
Console.WriteLine();
///////////////////////////////////////////////////////
Console.WriteLine("Exercicios dificeis:");

Console.Write("1 - Insira um usuario");
string usuario = Console.ReadLine();
Console.Write("1 - Insira a senha");
string senha = Console.ReadLine();
string senhaCorreta = "1234";
string usuarioCorreto = "admin";

bool podentra = (usuario == usuarioCorreto) && (senha == senhaCorreta);
if (podentra)
{
    Console.Write("Acesso Liberado");
}
else
{
    Console.Write("Acesso Negado");
}
Console.WriteLine();


Console.Write("2 - Insira o primeiro numero:");
int numeroD1 =  Convert.ToInt32(Console.ReadLine());
Console.Write("2 - Insira o segundo numero:");
int numeroD2 = Convert.ToInt32(Console.ReadLine());
Console.Write("2 - Insira o terceiro numero:");
int numeroD3 = Convert.ToInt32(Console.ReadLine());
bool numero1maior = (numeroD1 > numeroD2)  && (numeroD1 > numeroD3);
bool numero2maior = (numeroD2 > numeroD1) && (numeroD2 > numeroD3);

if (numero1maior)
{
    Console.Write($"O maior numero e o {numeroD1}");
}else if (numero2maior)
{
    Console.Write($"O maior numero e o {numeroD2}");
}
else
{
    Console.Write($"O maior numero e o {numeroD3}");
}

Console.WriteLine();

Console.Write("3 - Insira o salario do funcionario:");
double salario = Convert.ToDouble(Console.ReadLine());
bool mais2mil = salario > 2000;
double salarioMaior = salario * 0.10;
double salarioMenor = salario * 0.20;
if (mais2mil)
{
    Console.Write($"O seu salario sera de {salario + salarioMaior}");
}
else
{
    Console.Write($"O seu salario sera de {salario + salarioMenor}");
}
Console.WriteLine();

Console.Write("Digite o ano: ");
int ano15 = Convert.ToInt32(Console.ReadLine());

// Regra completa do calendário gregoriano para ano bissexto
bool bissexto = (ano15 % 4 == 0 && ano15 % 100 != 0) || (ano15 % 400 == 0);

if (bissexto)
{
    Console.Write($"O ano {ano15} é bissexto.");
}
else
{
    Console.Write($"O ano {ano15} não é bissexto.");
}
Console.WriteLine();

Console.Write("5 - Digite sua idade:");
int idade12 = Convert.ToInt32(Console.Read());
Console.Write("5- voce tem convite?");
bool convite1 = Convert.ToBoolean(Console.Read());
bool podentra2 = (idade >= 18) && convite1;
if (podentra2)
{
    Console.Write("Pode entrar");
}
else
{
    Console.Write("Nao pode entrar");
}