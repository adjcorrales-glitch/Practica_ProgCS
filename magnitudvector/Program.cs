using System;

class Program
{
    static void Main()
    {
        int[] V = { 3, 4, 5, 6, 7 };
        double suma = 0;

        // Elevar al cuadrado y sumar
        for (int i = 0; i < V.Length; i++)
        {
            suma += Math.Pow(V[i], 2);
        }

        // Calcular magnitud
        double magnitud = Math.Sqrt(suma);

        // Mostrar resultado
        Console.WriteLine("La magnitud del vector es: " + magnitud);
    }
}
