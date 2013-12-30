using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Item model. Stores statistics about items.
/// Note: Inventory collections should only reference items, not store instances.
/// </summary>
public class Item
{
#region Constants/Enums
	[System.Flags]
	public enum ItemProperties
	{
		None = 0,
		Storable = 1
	}
#endregion

#region Properties
	private int _ItemID;
	public int ItemID
	{
		get { return _ItemID; }
		set { _ItemID = value; }
	}
	
	private string _Name;
	public string Name
	{
		get { return _Name; }
		set { _Name = value; }
	}

	private Sprite _Icon;
	public Sprite Icon
	{
		get { return _Icon; }
		set 
		{ 
			// TODO: Constrain icons to a certain size, or automatically resize them.
			_Icon = value; 
		}
	}
	
	private ItemProperties _Properties;
	public ItemProperties Properties
	{
		get { return _Properties; }
		set { _Properties = value; }
	}

	private List<IMatter> _Matter;
	public List<IMatter> Matter
	{
		get { return _Matter; }
		set { _Matter = value; }
	}
#endregion


#region Constructors
	public Item(string name, Sprite icon, List<IMatter> matter)
	{
		Name = name;
		Icon = icon;
		Properties = ItemProperties.None;
		Matter = matter;
	}

	public Item(string name, Sprite icon, IMatter[] matter)
	{
		Name = name;
		Icon = icon;
		Properties = ItemProperties.None;
		Matter = new List<IMatter>();

		for (int i = 0; i < matter.Length; i++)
		{
			Matter.Add(matter[i]);
		}
	}
#endregion
}