using UnityEngine;
using System.Collections.Generic;

public sealed class AtomsDAO
{
	private Atom[] _Atoms;
	public Atom[] Atoms
	{
		get { return _Atoms; }
		set { _Atoms = value; }
	}

	// Get atom by AtomID (atomic number).
	public Atom this[int atomID]
	{	
		get {
			Atom atom;
			for (int i = 0; i < Atoms.Length; i++)
			{
				atom = (Atom) Atoms[i];
				
				if (atom.AtomID == atomID)
				{
					return atom;
				}
			}

			Debug.LogWarning ("AtomsDAO: Could not find atom with ID " + atomID);
			return null;
		}
	}

	// Get atom by name or symbol.
	public Atom this[string atomName]
	{
		get {
			Atom atom;
			for (int i = 0; i < Atoms.Length; i++)
			{
				atom = (Atom) Atoms[i];

				// Search by symbol.
				if (atomName.Length < 3)
				{
					if (atom.Symbol == atomName)
					{
						return atom;
					}
				}

				// Search by name.
				else if (atom.Name == atomName)
				{
					return atom;
				}
			}
			
			Debug.LogWarning ("AtomsDAO: Could not find atom with name/symbol '" + atomName + "'");
			return null;
		}
	}
}