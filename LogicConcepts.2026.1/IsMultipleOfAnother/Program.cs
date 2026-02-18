using Shared;

do
{
    var a = ConsoleExtensions.GetInt("Ingrese primer número : ");
    var b = ConsoleExtensions.GetInt("Ingrese segundo número : ");

    if (a % b == 0)
    {
        Console.WriteLine($"{a} es múltiplo de {b}");
    }
    else
    {
        Console.WriteLine($"{a} no es múltiplo de {b}");
    }


} while (true);
