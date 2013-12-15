using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider2D))]
[AddComponentMenu("Containers/Reactor Input Slot")]
public sealed class ReactorInputSlot : Slot, IClickable
{
#region Properties
	[SerializeField]
	private Sprite _iconAdd;
	public Sprite IconAdd
	{
		get { return _iconAdd; }
		set { _iconAdd = value; }
	}

	[SerializeField]
	private Sprite _iconUnavailable;
	public Sprite IconUnavailable
	{
		get { return _iconUnavailable; }
		set { _iconUnavailable = value; }
	}

	private Item _item;
	public Item Item 
	{ 
		get { return _item; }
		set { _item = value; }
	}
	
	private int _quantity;
	public int Quantity 
	{
		get { return _quantity; }
		set { _quantity = value; }
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
