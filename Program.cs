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
static int CalcularNotaMayor(int[] notas)
{
    int mayor = notas[0];
    for(int i=1; i<notas.Length; i++)
    {
        if(notas[i] > mayor)
        {
            mayor = notas[i];
        }
    }
    return mayor;
}   
static int CalcularNotaMenor(int[] notas)
{
    int menor = notas[0];
    for(int i=1; i<notas.Length; i++)
    {
        if(notas[i] < menor)
        {
            menor = notas[i];
        }
    }
    return menor;
}   
double promedio = CalcularPromedio(notas);
System.Console.WriteLine($"El promedio es: {promedio}");

int mayor = CalcularNotaMayor(notas);
int menor = CalcularNotaMenor(notas);
Console.WriteLine($"La nota mayor es: {mayor}");
Console.WriteLine($"La nota menor es: {menor}");