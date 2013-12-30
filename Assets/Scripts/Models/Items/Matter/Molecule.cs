using System.Collections.Generic;

public class Molecule : IMatter
{
#region Properties
	private int _MoleculeID;
	public int MoleculeID
	{
		get { return _MoleculeID; }
		set { _MoleculeID = value; }
	}

	private string _Name;
	public string Name
	{
		get { return _Name; }
		set { _Name = value; }
	}

	private string[] _Atoms;
	public string[] Atoms
	{ 
		get { return _Atoms; } 
		set { _Atoms = value; }
	}
#endregion

	
#region Constructors
	public Molecule() {}

	public Molecule(int moleculeID, string name, string[] atoms)
	{
		MoleculeID = moleculeID;
		Name = name;
		Atoms = atoms;
	}
#endregion
}
