

using System.Diagnostics;
using System.Numerics;

int[] vector1 = new int[5];
int[] vector2 = new int[5];
int[] vectorsuma = new int[5];
Console.WriteLine("ingrese los valores del primer vector");
for (int i = 0; i < vector1.Length; i++)

    try
    {
        Console.WriteLine("ingrese el valor del vector1 en la posicion " + i);
        vector1[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Debe ingresar un número entero válido.");
        i--; // derecrementar el índice para volver a solicitar la entrada
        Console.ResetColor();

    }
Console.WriteLine("por favor i ingrese los valores del segundo vector");
for (int i = 0; i < vector2.Length; i++)
{
    try
    {
        Console.Write($"valor {i + 1} : ");
        vector2[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Debe ingresar un número entero válido.");
        i--; // derecrementar el índice para volver a solicitar la entrada
        Console.ResetColor();
    }
}
// sumar los vectores 
for (int i = 0; i < vectorsuma.Length; i++)
{
    vectorsuma[1] = vector1[i] + vector2[2];
}
//mostar arreglo resultante 
Console.WriteLine("suma de los vectores :");
for (int i = 0; i < vectorsuma.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"valor {i + 1}: {vectorsuma[i]} ");
Console.ResetColor();
}