/* almacenar 10 edades en un arreglo, luego mostrar el promedio de las edades, la edad mayor y la edad menor */
//crear arreglo de edades
int [] edades = new int[10];
//pedir edades
for (int i = 0; i < edades.Length; i++)
try 
{
    Console.WriteLine("Ingrese la edad " + (i + 1) + ":");
    edades[i] = int.Parse(Console.ReadLine());
}
catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ingrese un numero valido");
        i--;
        Console.ResetColor();
    }

    //calcular promedio, maximo y minimo
int suma = 0;
int maximo = edades[0];
int minimo = edades[0];

for (int i = 0; i < edades.Length; i++)
{
    suma += edades[i];
    if (edades[i] > maximo)
    {
        maximo = edades[i];
    }
    if (edades[i] < minimo)
    {
        minimo = edades[i];
    }
}

int promedio = suma / edades.Length;