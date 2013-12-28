public sealed class Services
{


	static StaticData _staticData = new StaticData();
	public static StaticData StaticData
	{
		get { return _staticData; }
	}
}