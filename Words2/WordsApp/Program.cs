using System;
using System.Linq;

namespace WordsApp
{
	class Program
	{
		static void Main(string[] args)
		{
			//Skriv en konsolapplikation som tar emot en skriven text.
			Console.WriteLine("Enter a string, preferrably containing a sentence.");
			
			char[] vowels = new char[] { 'a', 'o', 'i', 'e', 'u', 'y', 'å', 'ä', 'ö'};

			string enteredString = Console.ReadLine();
			string myLowercaseString = enteredString.ToLower();

			string[] words = enteredString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
			int vowelCount = 0;
			int wordCount = words.Length;
			string longestWord;

			foreach (var character in myLowercaseString)
			{
				//var normalizedCharacter =char.ToLower(character)
				if (vowels.Contains(character)
				{
					
						
				}
			}
			foreach (var character in words)
			{
				foreach (var character in word)
				{
					vowelCount++;
				}
			}

			if (wordCount.Length > longestWord.Length)
			{

			}

			for (var i = 0; i < enteredString; i++)
			{
				var character = enteredString[i];
			}

			Console.WriteLine("Word count: " + wordCount);
			Console.WriteLine("Vowel count: " + vowelCount);
			Console.WriteLine("Longest word: " + longestWord + ", " + longestWord + " character");

			/*
			Vi vill ha ut följande:
			Antal ord?
			Antal vokaler?
			Vilket är det längsta ordet?

			Word count
			Vowel count
			Longest word
			*/
		}
	}
}
