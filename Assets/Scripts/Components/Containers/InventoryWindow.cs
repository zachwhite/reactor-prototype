using UnityEngine;
using System.Collections;


public class InventoryWindow : MonoBehaviour 
{
	private InventorySlot[] _InventorySlots;
	public InventorySlot[] InventorySlots
	{
		get { return _InventorySlots; }
		set { _InventorySlots = value; }
	}


	public void Show()
	{
		gameObject.SetActive(true);
	}
	
	
	public void Hide()
	{
		gameObject.SetActive(false);
	}
	
	
	private void PopulateSlots()
	{
		
	}

}
