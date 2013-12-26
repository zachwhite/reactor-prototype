using UnityEngine;
using System.Collections;
using LitJson;

public sealed class StaticData 
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

	private MoleculesDAO _moleculesData;
	public MoleculesDAO MoleculesData
	{
		get
		{
			// Lazy loading.
			if (_moleculesData == null)
				loadMoleculesData ();
			return _moleculesData;
		}
		set { _moleculesData = value; }
	}
#endregion
	
	
	public void loadAtomsData()
	{
		TextAsset jsonResource = (TextAsset) Resources.Load (RESOURCES.STATIC_DATA.ATOMS, typeof(TextAsset));
		AtomsData = JsonMapper.ToObject<AtomsDAO>(jsonResource.text);
	}


	public void loadMoleculesData()
	{
		TextAsset jsonResource = (TextAsset) Resources.Load (RESOURCES.STATIC_DATA.MOLECULES, typeof(TextAsset));
		MoleculesData = JsonMapper.ToObject<MoleculesDAO>(jsonResource.text);
	}
}
