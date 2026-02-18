using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    var name = ConsoleExtensions.GetString("Ingrese nombre..........................: ");
    var hoursWorked = ConsoleExtensions.GetFloat("Ingrese número de horas trabajadas......: ");
    var hourValue = ConsoleExtensions.GetDecimal("Ingrese valor hora......................: ");
    var salaryMinimum = ConsoleExtensions.GetDecimal("Ingrese valor salario mínimo mensual....: ");

    // calculate the salary of the employee
    var salary = (decimal)hoursWorked * hourValue;

    if (salary < salaryMinimum)
    {
        Console.WriteLine($"Nombre..................................: {name}");
        //Console.WriteLine($"Salario.................................: {salaryMinimum:C2}");
    }
    else
    {
        Console.WriteLine($"Nombre..................................: {name}");
        Console.WriteLine($"Salario.................................: {salary:C2}");
    }
    
    // Validate that the user enters a valid option to continue or not with the programme
    do
    {
        answer = ConsoleExtensions.GetValidOptions("¿Desea continuar [S]i, [N]o}?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

