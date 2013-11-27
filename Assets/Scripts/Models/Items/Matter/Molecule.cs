using System.Collections.Generic;

public class Molecule : IMatter
{
#region Properties
	private string _name;
	public string Name
	{
		get { return _name; }
		set { _name = value; }
	}

	private List<Atom> _atoms;
	public List<Atom> Atoms
	{ 
		get { return _atoms; } 
		set { _atoms = value; }
	}

#endregion

	
#region Constructors
	public Molecule(string name, List<Atom> atoms)
	{
		Name = name;
		Atoms = atoms;
	}

	public Molecule(string name, Atom[] atoms)
	{
		Name = name;
		Atoms = new List<Atom>();
		for (int i = 0; i < atoms.Length; i++)
		{
			Atoms.Add(atoms[i]);
		}
	}
#endregion
}
