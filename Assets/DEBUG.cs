using UnityEngine;
using System.Collections;

public class DEBUG : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StaticData staticData = new StaticData();
		staticData.loadAtomsData();
		Debug.Log ("Atom name: " + staticData.AtomsData[2].Name);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
