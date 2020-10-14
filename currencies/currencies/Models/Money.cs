using System;

namespace currencies.Models
{
	public struct Money
	{
		public Money (decimal amount, string currency)
		{
			Amount = amount;
			Currency = currency.ToUpper();
		}
		public decimal Amount { get; set; }
		public string Currency { get; set; }

		public override string ToString()
		{
			return $"{Math.Round(Amount, 2)} {Currency}";
		}
	}
}
