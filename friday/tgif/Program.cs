using System;
using System.Globalization;

namespace tgif
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv en applikation som läser in ett datum via användarinmatning,
            // som sedan räknar ut hur många dagar det är till nästa fredag.

            Console.WriteLine("Skriv in ett datum yyyy-mm-dd");
            var dateInput = Console.ReadLine().ToString();
            Console.WriteLine();

            CultureInfo culture = new CultureInfo("sv-SE");

            DateTime.TryParse(dateInput, culture, DateTimeStyles.AssumeLocal , out DateTime parsedDate);

            int daysUntilFriday = ((int)DayOfWeek.Friday - (int)parsedDate.DayOfWeek + 7) % 7;
            //DateTime nextFriday = parsedDate.AddDays(daysUntilFriday); // Skriver ut vilket datum nästa fredag är

            Console.WriteLine($"Från datumet {parsedDate.ToShortDateString()} är det {daysUntilFriday} dagar tills det är fredag.");

        }
    }
}
