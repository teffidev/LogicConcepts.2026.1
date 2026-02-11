using Shared;

var answer = string.Empty;
var options = new List<string>("s", "n");
do
{
    var number = ConsoleExtensions.GetInt("Ingrese número entero diferente de cero: ");
    if (number == 0)
    {
        continue;
    }

    if (number % 2 == 0)
    {
        Console.WriteLine($"El número {number} es Par");
    }
    else
    {
        Console.WriteLine($"El número {number} es Impar");
    }  
} while (true);
