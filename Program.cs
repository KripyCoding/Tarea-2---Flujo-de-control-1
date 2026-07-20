using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo culturaRD = CultureInfo.GetCultureInfo("es-DO");

        Console.WriteLine("==============================================");
        Console.WriteLine("      CALCULADORA DE ISR - RD 2026");
        Console.WriteLine("==============================================");
        Console.Write("Digite el sueldo mensual bruto del empleado: RD$ ");

        string entrada = Console.ReadLine() ?? "";

        if (!decimal.TryParse(entrada, NumberStyles.Number, culturaRD, out decimal sueldoMensual)
            || sueldoMensual <= 0)
        {
            Console.WriteLine("Error: debe introducir un sueldo válido mayor que cero.");
            return;
        }

        decimal sueldoAnual = sueldoMensual * 12;
        decimal isrAnual;

        
        if (sueldoAnual <= 416220.00m)
        {
            isrAnual = 0;
        }
        else if (sueldoAnual <= 624329.00m)
        {
            isrAnual = (sueldoAnual - 416220.01m) * 0.15m;
        }
        else if (sueldoAnual <= 867123.00m)
        {
            isrAnual = 31216.00m + ((sueldoAnual - 624329.01m) * 0.20m);
        }
        else
        {
            isrAnual = 79776.00m + ((sueldoAnual - 867123.01m) * 0.25m);
        }

        decimal isrMensual = isrAnual / 12;


        Console.WriteLine("\n--------------- RESULTADO -------------------");
        Console.WriteLine("Sueldo mensual: {0}", sueldoMensual.ToString("C2", culturaRD));
        Console.WriteLine("Sueldo anual:   {0}", sueldoAnual.ToString("C2", culturaRD));

        string isrMensualTexto = isrAnual == 0 ? "N/A" : isrMensual.ToString("C2", culturaRD);
        string isrAnualTexto = isrAnual == 0 ? "N/A" : isrAnual.ToString("C2", culturaRD);

        Console.WriteLine("ISR mensual:    {0}", isrMensualTexto);
        Console.WriteLine("ISR anual:      {0}", isrAnualTexto);

        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Cálculo educativo basado en la escala DGII 2026.");
        Console.ReadKey();
    }
}
