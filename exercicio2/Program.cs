﻿Console.WriteLine("Possui presença minima?");
string presença = Console.ReadLine();
if (presença == "sim" || presença == "Sim")
{
    Console.WriteLine($"Possui média maior ou igual a 7?");
}
else if (presença == "Não" || presença == "não");
    Console.WriteLine("reprovado");


double nota1 = 5.5;
double nota2 = 8.0;
double nota3 = 6.8;
double mediaNota = (nota1 + nota2 + nota3) / 3;
if (mediaNota >= 7)
{
    Console.WriteLine($"Média {mediaNota:F2} Aprovado");
}
else if (mediaNota >= 5 && mediaNota < 7)
{
    Console.WriteLine($"Média {mediaNota:F2}: Reprovado");
}