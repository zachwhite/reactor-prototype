using System.Collections.Generic;

public class Molecule : IMatter
{
#region Properties
	private int _moleculeID;
	public int MoleculeID
	{
		get { return _moleculeID; }
		set { _moleculeID = value; }
	}

	private string _name;
	public string Name
	{
		get { return _name; }
		set { _name = value; }
	}

	private string[] _atoms;
	public string[] Atoms
	{ 
		get { return _atoms; } 
		set { _atoms = value; }
	}
#endregion

	
#region Constructors
	public Molecule() {}

	public Molecule(int moleculeID, string name, string[] atoms, AtomsDAO atomsDAO)
	{
		MoleculeID = moleculeID;
		Name = name;
		Atoms = atoms;
		AtomsDAO = atomsDAO;
	}
#endregion
}
