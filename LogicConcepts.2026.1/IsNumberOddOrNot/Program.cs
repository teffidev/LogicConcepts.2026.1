var numberString = string.Empty;
do
{
    Console.Write("Ingrese número entero o presione 'Salir' para salir: ");
    numberString = Console.ReadLine();
    if (numberString!.ToLower() == "salir")
    {
        continue;
    }

    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El número {numberInt} es Par");
        }
        else
        {
            Console.WriteLine($"El número {numberInt} es Impar");
        }
    }
    else
    {
        Console.WriteLine($"Lo que ingresaste: {numberString} no es un número entero");
    }    
} while (numberString!.ToLower() != "salir");
Console.WriteLine("Game over.");
