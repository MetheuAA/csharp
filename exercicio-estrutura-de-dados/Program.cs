// exercicio 1 (somar todos os elementos do array e exiba o resultado no console)

int[] array = { 1, 2, 3, 4, 5 };
int sum = 0;

foreach (int num in array)
{
    sum += num;
}
Console.WriteLine(sum);