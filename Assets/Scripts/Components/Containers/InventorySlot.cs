using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider2D))]
[AddComponentMenu("Containers/Inventory Slot")]
public sealed class InventorySlot : Slot, IClickable
{
#region Properties
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
		Icon = Item.Icon;
	}


	public void OnMouseDown() {}
	
	public void OnMouseUp()
	{
		
	}



	/// <summary>
	/// Increment Quantity by 1.
	/// </summary>
	public bool Increment() { return Increment(1); }

	/// <summary>
	/// Increment Quantity by the specified amount.
	/// </summary>
	/// <param name="amount">Amount to add to Quantity.</param>
	public bool Increment(int amount)
	{
		// Amount must be positive.
		if (amount > 0)
		{
			// Quantity is Infinite, don't adjust.
			if (Quantity == -99)
			{
				return true;
			}

			Quantity += amount;

			// Cap items
			if (Quantity > 99)
			{
				Quantity = 99;
			}

			return true;
		}

		return false;
	}


	/// <summary>
	/// Decrement Quantity by 1.
	/// </summary>
	public bool Decrement() { return Decrement(1); }

	/// <summary>
	/// Decrement Quanity by the specified amount.
	/// </summary>
	/// <param name="amount">Amount to subtract from Quanity.</param>
	public bool Decrement(int amount)
	{
		if (amount > 0)
		{
			// Quantity is Infinite, don't adjust.
			if (Quantity == -99)
			{
				return true;
			}

			Quantity -= amount;

			// Can't go under 0
			if (Quantity < 0)
			{
				Quantity = 0;
			}

			return true;
		}

		return false;
	}


}
