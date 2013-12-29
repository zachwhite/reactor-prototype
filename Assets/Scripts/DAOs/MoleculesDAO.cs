using UnityEngine;
using System.Collections.Generic;

public sealed class MoleculesDAO
{
	private Molecule[] _molecules;
	public Molecule[] Molecules
	{
		get { return _molecules; }
		set { _molecules = value; }
	}

	public Molecule this[int moleculeID]
	{	
		get {
			Molecule molecule;
			for (int i = 0; i < Molecules.Length; i++)
			{
				molecule = (Molecule) Molecules[i];
				
				if (molecule.MoleculeID == moleculeID)
				{
					return molecule;
				}
			}
			
			Debug.LogWarning ("MoleculeDAO: Could not find molecule with ID " + moleculeID);
			return null;
		}
	}


	public Molecule this[string moleculeName]
	{
		get {
			Molecule molecule;
			for (int i = 0; i < Molecules.Length; i++)
			{
				molecule = (Molecule) Molecules[i];

				if (molecule.Name == moleculeName)
				{
					return molecule;
				}
			}

			Debug.LogWarning ("MoleculeDAO: Could not find molecule with name '" + moleculeName + "'");
			return null;
		}
	}
}