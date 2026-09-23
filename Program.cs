static void ImprimirNotas(int[] notas)
{
    for (int i=0; i < notas.Length; i++)
{
    System.Console.WriteLine(notas[i]);
}
}


int[] notas = [15,18,12,17,20];

ImprimirNotas(notas);
static double CalcularPromedio(int[] notas)
{
    int suma=0;
    for(int i = 0; i < notas.Length; i++)
    {
        suma+=notas[i];
    }
    return (double) suma / notas.Length;
    
}
double promedio = CalcularPromedio(notas);
System.Console.WriteLine($"El promedio es: {promedio}");
