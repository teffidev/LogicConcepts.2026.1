using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    Console.WriteLine("Ingrese tres números diferentes.");
    var a = ConsoleExtensions.GetInt("Ingrese primer número : ");
    var b = ConsoleExtensions.GetInt("Ingrese segundo número : ");

    if (a == b)
    {
        Console.WriteLine("Los numeros deben ser diferentes, vuelva a empezar");
        continue;
    }

    var c = ConsoleExtensions.GetInt("Ingrese tercer número : ");

    if (b == c || c == a)
    {
        Console.WriteLine("Los numeros deben ser diferentes, vuelva a empezar");
        continue;
    }

    if (a > b && a > c)
    {
        if (b > c)
        {
            Console.WriteLine($"El mayor es {a}, el medio es {b}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El mayor es {a}, el medio es {c}, el menor es {b}");
        }
    }
    else if (b > a && b > c)
    {
        if (a > c)
        {
            Console.WriteLine($"El mayor es {b}, el medio es {a}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El mayor es {b}, el medio es {c}, el menor es {a}");
        }
    }
    else
    {
        if (a > b)
        {
            Console.WriteLine($"El mayor es {c}, el medio es {a}, el menor es {b}");
        }
        else
        {
            Console.WriteLine($"El mayor es {c}, el medio es {b}, el menor es {a}");
        }
    }

    // Validate that the user enters a valid option to continue or not with the programme
    do
    {
        answer = ConsoleExtensions.GetValidOptions("¿Desea continuar [S]i, [N]o}?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
