using UnityEngine;
using System.Collections;
using LitJson;

public sealed class StaticData 
{
#region Properties
	private StaticData[] _instantiations;
	public StaticData[] Instantiations
	{
		get { return _instantiations; }
		set { _instantiations = value; }
	}

	private AtomsDAO _atomsData;
	public AtomsDAO AtomsData
	{
		get { return _atomsData; }
		set { _atomsData = value; }
	}

	private MoleculesDAO _moleculesData;
	public MoleculesDAO MoleculesData
	{
		get { return _moleculesData; }
		set { _moleculesData = value; }
	}
#endregion

#region Constructors
	public StaticData() {}

	public StaticData(string resourceLocations)
	{

	}
#endregion


	public void loadAtomsData(string resourceLocation)
	{
		TextAsset jsonResource = (TextAsset) Resources.Load (resourceLocation, typeof(TextAsset));
		AtomsData = JsonMapper.ToObject<AtomsDAO>(jsonResource.text);
	}


	public void loadMoleculesData(string resourceLocation)
	{
		TextAsset jsonResource = (TextAsset) Resources.Load (resourceLocation, typeof(TextAsset));
		MoleculesData = JsonMapper.ToObject<MoleculesDAO>(jsonResource.text);
	}
}
