using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
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

    // Validate that the user enters a valid option to continue or not with the programme
    do
    {
        answer = ConsoleExtensions.GetValidOptions("¿Desea continuar [S]i, [N]o}?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
