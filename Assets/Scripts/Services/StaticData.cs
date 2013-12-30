using UnityEngine;
using System.Collections.Generic;
using LitJson;

public sealed class StaticData 
{
#region Properties
	private AtomsDAO _AtomsData;
	public AtomsDAO AtomsData
	{
		get { return _AtomsData; }
		set { _AtomsData = value; }
	}

	private MoleculesDAO _MoleculesData;
	public MoleculesDAO MoleculesData
	{
		get { return _MoleculesData; }
		set { _MoleculesData = value; }
	}
#endregion


#region Constructors
	public StaticData() {}

	public StaticData(string resourceLocations)
	{
		JsonData locations = JsonMapper.ToObject(resourceLocations);

		LoadAtomsData ((string) locations["Atoms"]);
		LoadMoleculesData ((string) locations["Molecules"]);
	}
#endregion


	/// <summary>
	/// Loads atoms data from a JSON formatted text file.
	/// </summary>
	/// <param name="resourceLocation">Location of the JSON file.</param>
	public void LoadAtomsData(string resourceLocation)
	{
		TextAsset jsonResource = (TextAsset) Resources.Load (resourceLocation, typeof(TextAsset));
		AtomsData = JsonMapper.ToObject<AtomsDAO>(jsonResource.text);
	}


	/// <summary>
	/// Loads molecules data from a JSON formatted text file
	/// </summary>
	/// <param name="resourceLocation">Location of the JSON file.</param>
	public void LoadMoleculesData(string resourceLocation)
	{
		TextAsset jsonResource = (TextAsset) Resources.Load (resourceLocation, typeof(TextAsset));
		MoleculesData = JsonMapper.ToObject<MoleculesDAO>(jsonResource.text);
	}
}