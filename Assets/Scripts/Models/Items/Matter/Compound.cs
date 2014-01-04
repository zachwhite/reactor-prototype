using System.Collections.Generic;

public sealed class Compound : IMatter
{
#region Properties
	private int _CompoundID;
	public int CompoundID
	{
		get { return _CompoundID; }
		set { _CompoundID = value; }
	}
	
	private string _Name;
	public string Name
	{
		get { return _Name; }
		set { _Name = value; }
	}

	private List<string[]> _Molecules;
	public List<string[]> Molecules
	{
		get { return _Molecules; }
		set { _Molecules = value; }
	}

	private string[] _Atoms;
	public string[] Atoms
	{ 
		get { return _Atoms; } 
		set { _Atoms = value; }
	}
#endregion


}
