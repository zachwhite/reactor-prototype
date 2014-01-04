using UnityEngine;

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public static class StringParser
{
	public const char SPLIT_CHAR = ((char)007);


	/// <summary>
	/// Split a string prepared by a StringParser method.
	/// </summary>
	/// <param name="inputString">Input string.</param>
	public static string[] Split(string inputString)
	{
		inputString = Regex.Replace(inputString, 
		                            SPLIT_CHAR.ToString () + SPLIT_CHAR.ToString (), 
		                            SPLIT_CHAR.ToString ());
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
		char lastCharacter = ((char)000);

		foreach (char character in inputString) 
		{
			if (Char.IsDigit(character) && 
			    !Char.IsDigit (lastCharacter) &&
			    stringBuilder.Length > 0)
			{
				stringBuilder.Append(SPLIT_CHAR);
				lastCharacter = SPLIT_CHAR;
			}

			else
			{
				stringBuilder.Append(character);
				lastCharacter = character;
			}
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
				if (character != SPLIT_CHAR)
					stringBuilder.Append(SPLIT_CHAR);
				stringBuilder.Append(character);
			}

			else if (character == ')')
			{
				stringBuilder.Append (SPLIT_CHAR);
				stringBuilder.Append(character);

				if (pass < inputString.Length)
				{
					stringBuilder.Append(SPLIT_CHAR);
				}
			}

			else
			{
				stringBuilder.Append(character);
			}
		}
		
		return stringBuilder.ToString ();
	}
}
