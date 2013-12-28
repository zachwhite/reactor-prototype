using UnityEngine;
using System.Collections.Generic;

public sealed class AtomsDAO
{
	private StaticData _staticData;
	public StaticData StaticData
	{
		get { return _staticData; }
		set { _staticData = value; }
	}

	private Atom[] _atoms;
	public Atom[] Atoms
	{
		get { return _atoms; }
		set { _atoms = value; }
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

	// Get atom by name.
	public Atom this[string atomName]
	{
		get {
			Atom atom;
			for (int i = 0; i < Atoms.Length; i++)
			{
				atom = (Atom) Atoms[i];
				
				if (atom.Name == atomName)
				{
					return atom;
				}
			}
			
			Debug.LogWarning ("AtomsDAO: Could not find atom with name '" + atomName + "'");
			return null;
		}
	}
}