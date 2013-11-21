using UnityEngine;
using System.Collections;

public class Item
{
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
}