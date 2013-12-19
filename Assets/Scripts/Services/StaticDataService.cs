using UnityEngine;
using System.Collections;

public class StaticDataService 
{
#region Properties
	private AtomsDAO _atomsData;
	private AtomsDAO AtomsData
	{
		get { return _atomsData; }
		set { _atomsData = value; }
	}
#endregion
	
	
	public void loadAtomsData()
	{
		TextAsset jsonResource = (TextAsset) Resources.Load (RESOURCES.STATIC_DATA.ATOMS, typeof(TextAsset));
		JSONObject jsonData = new JSONObject(jsonResource);
		
		
	}
}
