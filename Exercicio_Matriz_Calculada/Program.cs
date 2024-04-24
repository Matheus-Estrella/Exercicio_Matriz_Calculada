
// MATRIZES

const int size = 5;
float[,] matriz_1 = new float[size, size];
float[,] matriz_2 = new float[size, size];
float[,] resultado = new float[size, size];
int lin, col;

for (lin = 0; lin < size; lin++)
{
    for (col = 0; col < size; col++)
    {
        matriz_1[lin, col] = new Random().Next(1, 10);
        matriz_2[lin, col] = new Random().Next(1, 10);
    }
}

Console.WriteLine("\nImprimindo Matriz A: ");
for (lin = 0; lin < size; lin++)
{
    for (col = 0; col < size; col++)
    {
        Console.Write($"{matriz_1[lin, col]} "); ;
    }
    Console.WriteLine();
}
Console.WriteLine("\nImprimindo Matriz B: ");
for (lin = 0; lin < size; lin++)
{
    for (col = 0; col < size; col++)
    {
        Console.Write($"{matriz_2[lin, col]} "); ;
    }
    Console.WriteLine();
}

Console.WriteLine("\nImprimindo Matriz A+B: ");
for (lin = 0; lin < size; lin++)
{
    for (col = 0; col < size; col++)
    {
        resultado[lin, col] = matriz_1[lin, col] + matriz_2[lin, col];
        Console.Write($"{resultado[lin, col]} "); ;
    }
    Console.WriteLine();
}

Console.WriteLine("\nImprimindo Matriz A-B: ");
for (lin = 0; lin < size; lin++)
{
    for (col = 0; col < size; col++)
    {
        resultado[lin, col] = matriz_1[lin, col] - matriz_2[lin, col];
        Console.Write($"{resultado[lin, col]} "); ;
    }
    Console.WriteLine();
}
Console.WriteLine("\nImprimindo Matriz A*B: ");
for (lin = 0; lin < size; lin++)
{
    for (col = 0; col < size; col++)
    {
        resultado[lin, col] = matriz_1[lin, col] * matriz_2[lin, col];
        Console.Write($"{resultado[lin, col]} "); ;
    }
    Console.WriteLine();
}

Console.WriteLine("\nImprimindo Matriz A/B: ");
for (lin = 0; lin < size; lin++)
{
    for (col = 0; col < size; col++)
    {
        resultado[lin, col] = matriz_1[lin, col] / matriz_2[lin, col];
        Console.Write($"{resultado[lin, col]} "); ;
    }
    Console.WriteLine();
}