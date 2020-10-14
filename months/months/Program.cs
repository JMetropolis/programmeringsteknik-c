using System;
using System.Globalization;

namespace months
{
    class Program
    {


		static void Main(string[] args)
        {
			// Skriv ett program som tar en emot inmatad siffra (1-12)
			// och konverterar siffran till ett månadsnamn på svenska
			// programmet skall kasta ett fel om den inmatade siffran är något annat än 1-12.

			var input = 0;
			var valid = false;
			System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("sv-SE");

			while (!valid)
			{
				try
				{
					Console.Write("Skriv in ett nummer från 1 till 12: ");
					var totalString = Console.ReadLine();
					input = int.Parse(totalString);

					if (!(input <= 0) && !(input >= 13))
					{
						valid = true;
					}
					else
					{
						if (input <= 0)
						{
							Console.WriteLine("För lågt nummer!");
						}
						else
						{
							Console.WriteLine("För högt nummer!");
						}
					}
				}
				catch
				{
					Console.WriteLine("Är inte ett nummer!");
				}
			}
			
			string monthName = cultureInfo.DateTimeFormat.GetMonthName(input);
			Console.WriteLine($"Månaden är {monthName}.");


				// Varning! Värdelös kod nedan
				// Litet experiment med switch case vilket är ganska värdelöst när man kan få tag i infon via datetime

				/*var month = 0;

				try
				{
					Console.WriteLine("Skriv in ett nummer från 1 till 12:");
					var totalString = Console.ReadLine();
					month = int.Parse(totalString);
				}
				catch
				{
					Console.WriteLine("Fel tecken");
				}

				if (month <= 0 && month >= 13)
				{
					Console.Write("Månaden är: ");
				}
				else
				{
					Console.WriteLine($"{month} är inte ett ordentligt nummer.");
				}


				switch (month)
				{
					case 1:
						Console.WriteLine("Januari");
						break;
					case 2:
						Console.WriteLine("Februari");
						break;
					case 3:
						Console.WriteLine("Mars");
						break;
					case 4:
						Console.WriteLine("April");
						break;
					case 5:
						Console.WriteLine("Maj");
						break;
					case 6:
						Console.WriteLine("Juni");
						break;
					case 7:
						Console.WriteLine("Juli");
						break;
					case 8:
						Console.WriteLine("Augusti");
						break;
					case 9:
						Console.WriteLine("September");
						break;
					case 10:
						Console.WriteLine("Oktober");
						break;
					case 11:
						Console.WriteLine("November");
						break;
					case 12:
						Console.WriteLine("December");
						break;
					default:
						Console.WriteLine("Fel");
						break;
				*/
			}
	}
}
