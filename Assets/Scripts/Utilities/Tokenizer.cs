using System;
using System.Text.RegularExpressions;

public class Tokenizer
{
#region Properties
	private string _InputString;
	public string InputString 
	{
		get { return _InputString; }
		set { _InputString = value; }
	}
	
	private string _Match;
	public string Match
	{
		get { return _Match; }
		set { _Match = value; }
	}
	
	private string _SkipCharacters;
	public string SkipCharacters
	{
		get { return _SkipCharacters; }
		set { _SkipCharacters = value; }
	}
	
	public int _Position;
	public int Position
	{
		get { return _Position; }
		set { _Position = value; }
	}
#endregion


#region Constructors
	public Tokenizer (string inputString)
	{
		InputString = inputString;
		Match = " "; // TODO: Add line endings
		SkipCharacters = null;
		Position = 0;
	}
	
	public Tokenizer (string inputString, string match)
	{
		InputString = inputString;
		Match = match;
		SkipCharacters = null;
		Position = 0;
	}
	
	public Tokenizer (string inputString, string match, string skipCharacters)
	{
		InputString = inputString;
		Match = match;
		SkipCharacters = skipCharacters;
		Position = 0;
	}
#endregion
	
	
	/// <summary>
	/// Return the next token if the end of the stream isn't reached.
	/// </summary>
	public string Peek()
	{
		// End of stream reached.
		if (Position == InputString.Length)
		{
			return null;
		}

		MatchCollection matches = Regex.Matches (InputString.Substring (Position), Match);
		
		if (matches.Count == 0)
		{
			return null;
		}
		
		return matches[0].ToString ();
	}
	
	
	/// <summary>
	/// Returns the next token and iterates position.
	/// </summary>
	public string Take()
	{
		string result = Peek();
		if (result == null)
		{
			return null;
		}
		
		Position += result.Length;
		Skip();
		
		return result;
	}
	
	
	/// <summary>
	/// Consume next token, indicate whether it matches the given string.
	/// </summary>
	/// <param name="matchString">String to check.</param>
	public bool Consume(string matchString)
	{
		if (Take() == matchString)
			return true;
		
		return false;
	}
	
	
	/// <summary>
	/// Advance position for characters to be ignored.
	/// </summary>
	private void Skip()
	{
		if (SkipCharacters != null || SkipCharacters != "")
		{
			MatchCollection matches = Regex.Matches (InputString.Substring (Position), SkipCharacters);
			Position += matches[0].Length;
		}
	}
}
