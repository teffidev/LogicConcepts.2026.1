using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    Console.WriteLine("Ingrese tres números diferentes.");
    var a = ConsoleExtensions.GetInt("Ingrese primer número: ");
    var b = ConsoleExtensions.GetInt("Ingrese segundo número: ");
    var c = ConsoleExtensions.GetInt("Ingrese tercer número: ");

    if (a > b && a > c)
    {
        Console.WriteLine($"El número mayor es: {a}");
    } else if (b > a && b > c)
    {
        Console.WriteLine($"El número mayor es: {b}");
    } else
    {
        Console.WriteLine($"El número mayor es: {c}");
    }

    // Validate that the user enters a valid option to continue or not with the programme
    do
    {
        answer = ConsoleExtensions.GetValidOptions("¿Desea continuar [S]i, [N]o}?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
