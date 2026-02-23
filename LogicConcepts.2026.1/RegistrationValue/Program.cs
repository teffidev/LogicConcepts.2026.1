using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    var credits = ConsoleExtensions.GetInt("Número de créditos...........: ");
    var creditValue = ConsoleExtensions.GetDecimal("Valor crédito................: ");
    var stratum = ConsoleExtensions.GetInt("Estrato del estudiante.......: ");

    var registrationValue = CalculateRegistrationValue(credits, creditValue, stratum);
    var subsidy = CalculateSubsidy(stratum);

    Console.WriteLine($"Costo de la matricula........: {registrationValue, 20:C2}");
    Console.WriteLine($"Valos del subsidio...........: {subsidy, 20:C2}");

    do
    {
        answer = ConsoleExtensions.GetValidOptions("¿Desea continuar [S]i, [N]o}?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game Over!");

decimal CalculateSubsidy(int stratum)
{
    if (stratum == 1)
    {
        return 200000M;
    }
    if (stratum == 2)
    {
        return 100000M;
    }
    return 0;
}

decimal CalculateRegistrationValue(int credits, decimal creditValue, int stratum)
{
    decimal value;
    if (credits <= 20)
    {
        value = credits * creditValue;
    }
    else
    {
        value = 20 * creditValue + (credits - 20) * creditValue * 2; // with a 100% increase for credits above 20
    }

    if (stratum == 1)
    {
        return value * 0.2M; // 80% subsidy
    }
    if (stratum == 2)
    {
        return value * 0.5M; // 50% subsidy
    }
    if (stratum == 3)
    {
        return value * 0.7M; // 30% subsidy
    }

    return value;
}

