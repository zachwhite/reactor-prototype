using MonoConcept.Utilities;
using System.Collections.Generic;

public sealed class Atom : IMatter
{
#region Fields
	private string _name;
	private string _symbol;
	
	private int _electrons;
	private int _protons;
	private int _neutrons;
	
	private int[] _shell;
#endregion

	
#region Properties
	public string Name
	{
		get { return _name; }
		set { _name = value; }
	}

	public string Symbol
	{
		get { return _symbol; }
		set { _symbol = value; }
	}
	
	public int Electrons
	{
		get { return _electrons; }
		set { _electrons = value; arrangeShells(); }
	}
	
	public int Protons
	{
		get { return _protons; }
		set{ _protons = value; }
	}
	
	public int Neutrons
	{
		get { return _neutrons; }
		set { _neutrons = value; }
	}

	public List<Atom> Atoms
	{
		get 
		{ 
			List<Atom> atomList = new List<Atom>();
			atomList.Add(this);
			return atomList;
		}
	}
#endregion

	
#region Constructors
	public Atom (): 
	this("Dark Matter", "?", 0, 0, 0) {}
	
	public Atom (string name): 
		this(name, "?", 0, 0, 0) {}
	
	public Atom (int electrons, int protons, int neutrons): 
		this("Dark Matter", "?", electrons, protons, neutrons) {}

	public Atom (string name, int electrons, int protons, int neutrons):
		this(name, "?", electrons, protons, neutrons) {}
	
	public Atom (string name, string symbol, int electrons, int protons, int neutrons)
	{
		Name = name;
		Electrons = electrons;
		Protons = protons;
		Neutrons = neutrons;
	}
#endregion

	
#region Derived Properties
	// Return if this atom is an ion.
	public bool IsIon
	{
		get 
		{
			if (Protons != Electrons)
				return true;
			else
				return false;
		}
	}
	
	// Relative mass of the atom.
	public float Mass
	{
		get { return (float)(Protons + Neutrons); }
	}
	
	// Quantum of positive or negative charge.
	public int NetCharge
	{
		get { return Protons - Electrons; }
	}
	
	// Whether the atom is positive, negative, or zero charge.
	public int Charge
	{
		get
		{
			if (NetCharge != 0)
				return (NetCharge / -NetCharge) * -1;
			else
				return 0;
		}
	}	
	
	
	/**
	 * Return radius of the atomic nucleus.
	 */
	public float getNucleusRadius()
	{
		float nucleons = (float)(Electrons + Protons + Neutrons);
		return 1.07f * Maths.CubicRoot(nucleons);
	}
#endregion
	
	
	/**
	 * Nothing here, yet. Learn physics or something.
	 */
	private void arrangeShells()
	{
		
	}
}