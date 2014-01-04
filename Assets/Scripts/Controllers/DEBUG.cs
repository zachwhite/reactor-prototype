using UnityEngine;
using System.Collections;

public class DEBUG : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//StaticData staticData = new StaticData();
		Services.StaticData = new StaticData(RESOURCES.STATIC_DATA.PRODUCTION);

		StaticData staticData = Services.StaticData;
		// Debug.Log ("Atom name: " + staticData.AtomsData["Lead"].Name);
		// Debug.Log ("Molecule name: " + staticData.MoleculesData["Water"].Name);

		string[] elements = Chemistry.ParseFormula ("22HHe3(PbO)");
		for (int i = 0; i < elements.Length; i++)
			Debug.Log (elements[i]);

	}
	

}
