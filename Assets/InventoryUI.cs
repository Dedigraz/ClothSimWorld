
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
	public Transform itemsPanel;
	InventorySlot[] slots;
	Inventory inventory;
	// Start is called before the first frame update
	void Start()
	{
		inventory = Inventory.instance;
		inventory.onItemChangedCallback += UpdateUI;

		slots = itemsPanel.GetComponentsInChildren<InventorySlot>();
	}

	// Update is called once per frame
	void Update()
	{
		
	}
	void UpdateUI()
	{
		for (int i = 0; i < slots.Length; i++)
		{
			if (i < inventory.Items.Count)
			{
				slots[i].AddItem(inventory.Items[i]);
			}
			else
			{
				slots[i].ClearSlot();
			}
		}
	}
}
