int[] meuArray =  { 1, 2, 3, 4, 5};


// Loop com foreach
foreach (int i in meuArray)
{
    Console.WriteLine(i);
}

// Lista

List<string> listaNomes = new List<string>{"Wanderson", "Jaene", "Ryan"};
listaNomes.Add("Maria");
foreach (string i in listaNomes)
{
    Console.WriteLine(i);
}
listaNomes.Remove("Jaene");
foreach (string i in listaNomes)
{
    Console.WriteLine(i);
}

//Hash Set

HashSet<int> conjunto = new HashSet<int> { 1, 2, 3};
conjunto.Add(4);

foreach (int i in conjunto)
{
    Console.WriteLine(i);
}

Console.WriteLine("");

conjunto.Add(2);

foreach (int i in conjunto)
{
    Console.WriteLine(i);
}