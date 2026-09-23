static void ImprimirNotas(int[] notas)
{
    for (int i=0; i < notas.Length; i++)
{
    System.Console.WriteLine(notas[i]);
}
}


int[] notas = [15,18,12,17,20];

ImprimirNotas(notas);