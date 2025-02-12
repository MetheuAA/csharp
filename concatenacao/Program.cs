string nome = "Wanderson";
string saudacao = "Olá, " + nome + "! Bem-vindo.";
Console.WriteLine(saudacao);

string nome2 = "João";
string saudacao2 = $"Olá, {nome2}! Bem-vindo.";
Console.WriteLine(saudacao2);

int numero = 5;
Console.WriteLine(numero.GetType());

double numero2 = 2.5;
Console.WriteLine(numero2.GetType());

Console.WriteLine(typeof(int));

string valorTexto = "100";
Console.WriteLine("A variável valorTexto é do tipo: " + valorTexto.GetType());

int numero3 = int.Parse(valorTexto);
Console.WriteLine(numero3);
Console.WriteLine("A variável numeroParse é do tipo: " + numero3.GetType());

string valorTexto2 = "100";
Console.WriteLine("A variável valorTexto é do tipo: " + valorTexto2.GetType());

int numeroConvertido = Convert.ToInt32(valorTexto2);
Console.WriteLine(numeroConvertido);
Console.WriteLine("A variável numeroConvertido é do tipo" + numeroConvertido.GetType());