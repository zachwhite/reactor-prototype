using UnityEngine;
using System.Collections.Generic;

public class Item
{
#region Properties
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
		Matter = matter;
	}

	public Item(string name, Sprite icon, IMatter[] matter)
	{
		Name = name;
		Icon = icon;
		Matter = new List<IMatter>();

		for (int i = 0; i < matter.Length; i++)
		{
			Matter.Add(matter[i]);
		}
	}
#endregion
}