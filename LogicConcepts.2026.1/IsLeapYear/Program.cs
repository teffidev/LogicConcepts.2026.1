using Shared;

do
{
    var currentYear = DateTime.Now.Year;
    var message = string.Empty;
    var year = ConsoleExtensions.GetInt("Ingrese año: ");

    if (year == currentYear)
    {
        message = "es";
    }
    else if (year > currentYear)
    {
        message = "será";
    }
    else
    {
        message = "fue";
    }


    if (year % 4 == 0 )
    {
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine($"El año: {year}, SI {message} bisiesto");
            }
            else
            {
                Console.WriteLine($"El año: {year}, NO {message} bisiesto");
            }
        }
        else
        {
            Console.WriteLine($"El año: {year}, SI {message} bisiesto");
        }
    }
    else
    {
        Console.WriteLine($"El año: {year}, NO {message} bisiesto");
    }


} while (true);

