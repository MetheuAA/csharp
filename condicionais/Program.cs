// condicional if

int numero = 10;
if (numero > 0)
{
    Console.WriteLine("O número é positivo.");
}

//  condicional if-else

double nota1 = 5.5;
double nota2 = 8.0;
double nota3 = 6.8;
double media = (nota1 + nota2 + nota3) / 3;
if (media >= 7)
{
    Console.WriteLine($"Média {media:F2} Aprovado");
}
else{
    Console.WriteLine($"Média {media:F2} Recuperação");
}

// condicional else-if (if aninhado)

double nota4 = 5.5;
double nota5 = 8.0;
double nota6 = 6.8;
double mediaNota = (nota4 + nota5 + nota6) / 3;
if (mediaNota >= 7)
{
    Console.WriteLine($"Média {mediaNota:F2} Aprovado");
}
else if (mediaNota >= 5 && mediaNota < 7)
{
    Console.WriteLine($"Média {mediaNota:F2}: Recuperação");
}
else
{
    Console.WriteLine($"Média {mediaNota:F2} Recuperação");
}

// condicional if aninhado

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();
if (letra == "a" || letra == "A")
{
    Console.WriteLine($"A letra {letra} é uma vogal");
}
else if (letra == "e" || letra == "E")
{
    Console.WriteLine($"A letra {letra} é uma vogal");
}

else if (letra == "i" || letra == "I")
{
    Console.WriteLine($"A letra {letra} é uma vogal");
}

else if (letra == "o" || letra == "O")
{
    Console.WriteLine($"A letra {letra} é uma vogal");
}

else if (letra == "u" || letra == "U")
{
    Console.WriteLine($"A letra {letra} é uma vogal");
}
else{
    Console.WriteLine($"A letra {letra} não é uma vogal");
}

// condicional switch

string dia = "segunda";

switch (dia)
{
    case  "segunda":
        Console.WriteLine("Começo da semana");
        break;
    case "sexta":
        Console.WriteLine("Fim da semana chegando");
        break;
    default:
        Console.WriteLine("Dia qualquer");
        break;
}

// condicional ToLower

Console.WriteLine("Digite uma vogal");
string letra1 = Console.ReadLine();
string letraMinuscula = letra1.ToLower();
switch (letraMinuscula)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine($"A letra {letraMinuscula} é uma vogal");
        break;
    default:
        Console.WriteLine("A letra '{letraMinuscula}'não é uma vogal");
        break;
}

// condicional operador ternário

int idade = 18;
string mensagem = idade >= 18 ? "Maior de idade" : "Menor de idade";
Console.WriteLine(mensagem);