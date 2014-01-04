using System;
using System.Text;
using System.Collections.Generic;

public static class Chemistry
{
	public static string[] ParseFormula (string formula)
	{
		formula = StringParser.Parenthesis (formula);
		formula = StringParser.CapitalLetters (formula);
		formula = StringParser.Numbers (formula);

		string[] elements = StringParser.Split (formula);
		
		Compound compound = new Compound();

		int compoundIndex = 0;
		int multiplier = 1;
		List<string> currentMolecule = new List<string>();

		foreach (string element in elements)
		{
			// Multiply next series of elements by the multiplier.
			if ( !int.TryParse (element, out multiplier) )
			{
				multiplier = 1;
			}

			if ( element == "(" )
			{
				// TODO: Start adding next elements to new currentMolecule
			}

			if ( element == ")" )
			{
				// TODO: Parse currentMolecule into separate elements and multiply by multiplier.
			}


		}

		return elements;
	}
}
