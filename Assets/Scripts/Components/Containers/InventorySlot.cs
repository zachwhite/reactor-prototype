using UnityEngine;
using System.Collections;

[AddComponentMenu("Containers/Inventory Slot")]
public class InventorySlot : Slot
{
#region Properties
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
		Icon = Item.Icon;
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
