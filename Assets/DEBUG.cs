using UnityEngine;
using System.Collections;

public class DEBUG : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//StaticData staticData = new StaticData();
		Services.StaticData = new StaticData(RESOURCES.STATIC_DATA.PRODUCTION);

		StaticData staticData = Services.StaticData;
		Debug.Log ("Atom name: " + staticData.AtomsData["Lead"].Name);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
