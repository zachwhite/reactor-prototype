using UnityEngine;
using System.Collections.Generic;

public sealed class AtomsDAO
{
	private Atom[] _atoms;
	public Atom[] Atoms
	{
		get { return _atoms; }
		set { _atoms = value; }
	}

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

}
