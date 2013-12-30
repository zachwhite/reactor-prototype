using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider2D))]
[AddComponentMenu("Containers/Reactor Input Slot")]
public sealed class ReactorInputSlot : Slot, IClickable
{
#region Properties
	[SerializeField]
	private Sprite _IconAdd;
	public Sprite IconAdd
	{
		get { return _IconAdd; }
		set { _IconAdd = value; }
	}

	[SerializeField]
	private Sprite _IconUnavailable;
	public Sprite IconUnavailable
	{
		get { return _IconUnavailable; }
		set { _IconUnavailable = value; }
	}

	private Item _Item;
	public Item Item 
	{ 
		get { return _Item; }
		set { _Item = value; }
	}
	
	private int _Quantity;
	public int Quantity 
	{
		get { return _Quantity; }
		set { _Quantity = value; }
	}
#endregion

	public void Start()
	{
		if (Item != null)
			Icon = Item.Icon;
	}
	
	
	// Not used.
	public void OnMouseDown() {}
	
	
	public void OnMouseUp()
	{
		if (ContainsType != ContentTypes.BLOCKED)
		{
			// TODO: Bring up element selection screen.
		}
	}

}
