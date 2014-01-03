using UnityEngine;

using System;
using System.Text;

public static class StringParser
{
	public const char SPLIT_CHAR = ((char)007);

	/// <summary>
	/// Splits string at each capital letter.
	/// </summary>
	/// <returns>String array of split elements.</returns>
	/// <param name="inputString">The string to split.</param>
	public static string[] SplitCapitalLetters(string inputString)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char character in inputString) {
			if (Char.IsUpper(character) && stringBuilder.Length > 0) stringBuilder.Append(SPLIT_CHAR);
			stringBuilder.Append(character);
		}

		return stringBuilder.ToString ().Split (SPLIT_CHAR);
	}
}
