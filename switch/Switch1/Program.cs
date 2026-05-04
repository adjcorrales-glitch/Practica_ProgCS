/*leer un numero del 1 al 7 y decir que dia es*/
using System.Runtime.CompilerServices;
int numero = 0;

string dia = "";
Console.WriteLine("Ingrese un numero del 1 al 7");
try 
{
numero = int.Parse(Console.ReadLine());
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Error: " + ex.Message);
}
 

switch (numero)
{
    case 1:
        dia = "Lunes";
        break;
    case 2:
        dia = "Martes";
        break;
    case 3:
        dia = "Miercoles";
        break;
    case 4:
        dia = "Jueves";
        break;
    case 5:
        dia = "Viernes";
        break;
    case 6:
        dia = "Sabado";
        break;
    case 7:
        dia = "Domingo";
    break;
    default:
       
        Console.WriteLine("Numero no valido,escriba un numero del 1 al 7");
        break;
}
if (numero != 0) 
Console.WriteLine ($"El dia es {dia}. ");
