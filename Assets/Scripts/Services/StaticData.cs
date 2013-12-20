using UnityEngine;
using System.Collections;
using LitJson;

public class StaticData 
{
#region Properties
	private AtomsDAO _atomsData;
	public AtomsDAO AtomsData
	{
		get 
		{ 
			// Lazy loading.
			if (_atomsData == null)
				loadAtomsData();
				
			return _atomsData; 
		}
		set { _atomsData = value; }
	}
#endregion
	
	
	public void loadAtomsData()
	{
		TextAsset jsonResource = (TextAsset) Resources.Load (RESOURCES.STATIC_DATA.ATOMS, typeof(TextAsset));
		AtomsData = JsonMapper.ToObject<AtomsDAO>(jsonResource.text);
		
		
	}
}
