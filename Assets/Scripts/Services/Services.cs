public sealed class Services
{
	static StaticData _StaticData = new StaticData();
	public static StaticData StaticData
	{
		get { return _StaticData; }
		set { _StaticData = value; }
	}
}