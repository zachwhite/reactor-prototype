using UnityEngine;

using System;
using System.Text;

public static class StringParser
{
	public const char SPLIT_CHAR = ((char)007);


	/// <summary>
	/// Split a string prepared by a StringParser method.
	/// </summary>
	/// <param name="inputString">Input string.</param>
	public static string[] Split(string inputString)
	{
		return inputString.Split (SPLIT_CHAR);
	}


	/// <summary>
	/// Prepare string to be split at each capital letter.
	/// </summary>
	/// <returns>String array of split elements.</returns>
	/// <param name="inputString">The string to split.</param>
	public static string CapitalLetters(string inputString)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char character in inputString) 
		{
			if (Char.IsUpper(character) && 
			    stringBuilder.Length > 0)
			{
				stringBuilder.Append(SPLIT_CHAR);
			}

			stringBuilder.Append(character);
		}

		return stringBuilder.ToString ();
	}


	public static string Numbers(string inputString)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char character in inputString) 
		{
			if (Char.IsDigit(character) && 
			    stringBuilder.Length > 0)
			{
				stringBuilder.Append(SPLIT_CHAR);
			}
			
			stringBuilder.Append(character);
		}
		
		return stringBuilder.ToString ();
	}


	public static string Parenthesis (string inputString)
	{
		StringBuilder stringBuilder = new StringBuilder();

		int pass = 0;
		foreach (char character in inputString) 
		{
			pass++;

			if (character == '(' && 
			    stringBuilder.Length > 0)
			{
				stringBuilder.Append(SPLIT_CHAR);
				stringBuilder.Append(character);
			}
			


			else if (character == ')')
			{
				stringBuilder.Append (SPLIT_CHAR);
				stringBuilder.Append(character);

				if (pass < inputString.Length)
					stringBuilder.Append(SPLIT_CHAR);
			}

			else
			{
				stringBuilder.Append(character);
			}
		}
		
		return stringBuilder.ToString ();
	}
}
