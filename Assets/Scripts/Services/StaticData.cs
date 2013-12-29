using UnityEngine;
using System.Collections.Generic;
using LitJson;

public sealed class StaticData 
{
#region Properties
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
		JsonData locations = JsonMapper.ToObject(resourceLocations);

		loadAtomsData ((string) locations["Atoms"]);
		loadMoleculesData ((string) locations["Molecules"]);
	}
#endregion


	/// <summary>
	/// Loads atoms data from a JSON formatted text file.
	/// </summary>
	/// <param name="resourceLocation">Location of the JSON file.</param>
	public void loadAtomsData(string resourceLocation)
	{
		TextAsset jsonResource = (TextAsset) Resources.Load (resourceLocation, typeof(TextAsset));
		AtomsData = JsonMapper.ToObject<AtomsDAO>(jsonResource.text);
	}


	/// <summary>
	/// Loads molecules data from a JSON formatted text file
	/// </summary>
	/// <param name="resourceLocation">Location of the JSON file.</param>
	public void loadMoleculesData(string resourceLocation)
	{
		TextAsset jsonResource = (TextAsset) Resources.Load (resourceLocation, typeof(TextAsset));
		MoleculesData = JsonMapper.ToObject<MoleculesDAO>(jsonResource.text);
	}
}