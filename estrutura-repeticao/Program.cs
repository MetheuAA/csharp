Random numeroAleatorio = new Random();
int numero = numeroAleatorio.Next(1, 101);
int contador = 0;
Console.WriteLine($"Número Alvo: {numero}");
while (contador <= numero)
{
    Console.WriteLine($"Contador:{contador}");
    contador++;
}
Console.WriteLine($"Contador atingiu o número alvo: {contador}");

// Estrutura de repetição do...while

int numero1 = 0;

do{
    Console.WriteLine($"Número: {numero1}");
    numero1++;
} while (numero1 <10);