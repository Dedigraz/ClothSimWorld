using System.Collections;
using UnityEngine;


public class InventoryItem : IInteractable
{
	public Item Item;
	public override void Interact()
	{
		base.Interact();
	}

	void SelectCostume()
	{
		Debug.Log("Buying " + Item.name);
		bool wasAdded = Inventory.instance.Add(Item);

		//implement incrementation to stock
	}
}