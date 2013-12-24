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
	private int _itemID;
	public int ItemID
	{
		get { return _itemID; }
		set { _itemID = value; }
	}
	
	private string _name;
	public string Name
	{
		get { return _name; }
		set { _name = value; }
	}

	private Sprite _icon;
	public Sprite Icon
	{
		get { return _icon; }
		set 
		{ 
			// TODO: Constrain icons to a certain size, or automatically resize them.
			_icon = value; 
		}
	}
	
	private ItemProperties _properties;
	public ItemProperties Properties
	{
		get { return _properties; }
		set { _properties = value; }
	}

	private List<IMatter> _matter;
	public List<IMatter> Matter
	{
		get { return _matter; }
		set { _matter = value; }
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