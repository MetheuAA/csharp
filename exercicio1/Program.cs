Console.WriteLine("Maior que 18 anos?");
string idade = Console.ReadLine();
if (idade == "sim" || idade == "Sim")
{
    Console.WriteLine($" Entrada Liberada");
}
else if (idade == "Não" || idade == "não")
{
    Console.WriteLine($"Possui autorização do responsável?");

    string alternativa = Console.ReadLine();
    if (alternativa == "sim" || alternativa == "Sim")
    {
        Console.WriteLine($"Entrada Liberada");
    }
    else if (alternativa == "Não" || alternativa == "não")
    {
        Console.WriteLine($"Entrada Negada");
    }
}
