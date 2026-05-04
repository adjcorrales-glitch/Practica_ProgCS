//Pida al usuario un número entero y determina si el numero es positivo,negativo o cero,indica ademas si es par o impar*/
double num1,num2;
Console.WriteLine( $"ingresa un numero entero ");
num1 = double.Parse(Console.ReadLine());
try 
{
    if (num1 % 1 != 0)
    {
        Console.WriteLine("El número no es un entero, por favor ingresa un número entero.");
        return;
    }
}
catch (FormatException)
{
    Console.WriteLine("Entrada no válida. Por favor ingresa un número entero.");
    return;
}
if (num1 > 0)
{
switch (num1)
}

{
    Console.WriteLine("El número es positivo");
}
else if (num1 < 0)
{
    Console.WriteLine("El número es negativo");
}
else
{
    Console.WriteLine("El número es cero");
}
if (num1 % 2 == 0)
{
    Console.WriteLine("El número es par");
}
else
{
    Console.WriteLine("El número es impar");
}