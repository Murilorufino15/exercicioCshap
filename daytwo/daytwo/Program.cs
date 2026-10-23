//float valor1 = 10;
//float valor2 = 20;
//float valor3 = 15;
//float valor4 = 60;
//float valor5 = 5;

//float media = (valor1 + valor2 + valor3 + valor4 + valor5) / 2;
//Console.Write($"A media sera de: {media}");

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
Console.Write("defina o valor numero 1:");
double numero1 = double.Parse(Console.ReadLine());

Console.Write("defina o valor numero 2:");
double numero2 = double.Parse(Console.ReadLine());

Console.Write("defina o valor numero 3:");
double numero3 = double.Parse(Console.ReadLine());

Console.Write("defina o valor numero 4:");
double numero4 = double.Parse(Console.ReadLine());

Console.Write("defina o valor numero 5:");
double numero5 = double.Parse(Console.ReadLine());

//////////// TOSTRING EX {medial.ToString("F2")};

double media1 = (numero1 + numero2 + numero3 + numero4 + numero5) / 5;
double total = numero1 + numero2 + numero3 + numero4 + numero5;
double mudade = Math.Round(media1, 2);
Console.Write($"A media de {numero1} + {numero2} + {numero3} + {numero4} + {numero5} e igual a: {mudade}. O Valor total desta conta sem calcular a media e de: {total} ");