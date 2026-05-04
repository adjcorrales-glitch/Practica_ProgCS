/*leer un numero entero y mostrar todos sus antesesores elevados al cubo*/
using System.Data;
using math = System.Math;
  int numero;

  while (true)
  {
    Console.Write("ingresa tu numero entero ; ");
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        break;
    }
else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("entrada no valida, por favor, ingrese un numero entero. ");
        Console.ResetColor();

    }
}
Console.WriteLine ("los antesesores elevados al cubo son:" );
int contador = 1;
while (contador < numero)
{
    double cubo = math.Pow(contador, 3);
    Console.WriteLine($"{contador} elevado al cubo = {cubo} ");
    contador++;
}

