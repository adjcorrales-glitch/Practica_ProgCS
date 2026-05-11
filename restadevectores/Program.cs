using System;

class Program
{
    static void Main()
    {
        int[] A = { 15, 18, 20, 25, 30 };
        int[] B = { 5, 8, 10, 12, 15 };
        int[] resultado = new int[5];

        // Resta de vectores
        for (int i = 0; i < A.Length; i++)
        {
            resultado[i] = A[i] - B[i];
        }

        // Mostrar resultado
        Console.WriteLine("Vector resultante:");

        for (int i = 0; i < resultado.Length; i++)
        {
            Console.Write(resultado[i] + " ");
        }
    }
}