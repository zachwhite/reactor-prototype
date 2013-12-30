using MonoConcept.Utilities;
using System.Collections.Generic;

public sealed class Atom : IMatter
{
#region Properties
	private int _AtomID;
	public int AtomID
	{
		get { return _AtomID; }
		set { _AtomID = value; }
	}
	
	private string _Name;
	public string Name
	{
		get { return _Name; }
		set { _Name = value; }
	}

	private string _Symbol;
	public string Symbol
	{
		get { return _Symbol; }
		set { _Symbol = value; }
	}

	private int _Electrons;
	public int Electrons
	{
		get { return _Electrons; }
		set { _Electrons = value; ArrangeShells(); }
	}

	private int _Protons;
	public int Protons
	{
		get { return _Protons; }
		set{ _Protons = value; }
	}

	private int _Neutrons;
	public int Neutrons
	{
		get { return _Neutrons; }
		set { _Neutrons = value; }
	}

	public string[] Atoms
	{
		get 
		{ 
			string[] atom = new string[1] {
				Name
			};
			return atom;
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

	public Atom (JSONObject json)
	{
		AtomID = (int) json["id"].n;
		Name = json["name"].str;
		Electrons = (int) json["electrons"].n;
		Protons = (int) json["protons"].n;
		Neutrons = (int) json["neutrons"].n;
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
	public float NucleusRadius
	{
		get {
			float nucleons = (float)(Electrons + Protons + Neutrons);
			return 1.07f * Maths.CubicRoot(nucleons);
		}
	}
#endregion
	
	
	/**
	 * Nothing here, yet. Learn physics or something.
	 */
	private void ArrangeShells()
	{
		
	}
}