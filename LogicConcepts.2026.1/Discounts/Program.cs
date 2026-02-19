using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    var desks = ConsoleExtensions.GetInt("Número de escritorios: ");
    var valueToPay = CalculateValue(desks);       
    Console.WriteLine($"Valor a pagar........: {valueToPay:C2}");

    do
    {
        answer = ConsoleExtensions.GetValidOptions("¿Desea continuar [S]i, [N]o}?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

object CalculateValue(int desks)
{
    float discount;

    if (desks < 5)
    {
        discount = 0.1f; // 10% discount
    }
    else if (desks < 10)
    {
        discount = 0.2f; // 20% discount
    }
    else
    {
        discount = 0.4f; // 40% discount
    }

    return desks * 650000M * (decimal)(1 - discount);
}