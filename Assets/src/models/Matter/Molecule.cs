using System.Collections.Generic;

public class Molecule
{
#region Fields
	private string _name;
	
	private List<Atom> _atoms;
#endregion

	
#region Properties
	public string Name
	{
		get { return _name; }
		set { _name = value; }
	}
	
	public List<Atom> Atoms
	{ get { return _atoms; } }
#endregion

	
#region Constructors
	public Molecule()
	{
		
	}
#endregion
	
}
