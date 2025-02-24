// exercicio 1 

int[] array = { 1, 2, 3, 4, 5 };
int sum = 0;

foreach (int num in array)
{
    sum += num;
}
Console.WriteLine(sum);

//Fim
Console.WriteLine("");

// exercicio 2 
List<string> nomes = new List<string>{"Jeane", "Wanderson", "Jeane", "Ryan", "Jeane"};

int count = nomes.Count(nome => nome == "Jeane");
Console.WriteLine(count);

//Fim
Console.WriteLine("");

// exercicio 3 

List<int> numeros = new List<int> {1, 2, 2, 3, 4, 4, 5};

List<int> uniqueNumeros = numeros.Distinct().ToList();
Console.WriteLine(string.Join(", ", uniqueNumeros));
Console.WriteLine("");

// exercicio 4 

HashSet<string> frutas = new HashSet<string>{"Maçã", "Banana", "Laranja"};

bool existeBanana = frutas.Contains("Banana");

if (existeBanana)
{
    Console.WriteLine("Banana está presente na lista.");
}

// exercicio 5 
List<int> numeros1 = new List<int> {1, 2, 3, 4, 5};
foreach (int i in numeros1)
{
    Console.WriteLine(i);
}