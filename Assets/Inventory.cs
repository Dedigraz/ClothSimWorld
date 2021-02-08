using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
	public int space = 12;
	public List<Item> Items = new List<Item>();
	public static Inventory instance;

	public delegate void OnItemChanged();
	public OnItemChanged onItemChangedCallback;
	private void Awake()
	{
		if (instance != null)
		{
			Debug.LogWarning("More than one instance of inventory found");
			return;
		}
		instance = this;
	}

	public bool Add(Item item)
	{
		if (!item.isDefaultItem)
		{
			if (Items.Count >=space)
			{
				Debug.Log("Not enough space for item in inventory");
				return false;
			}
			Items.Add(item);

			if(onItemChangedCallback != null)
				onItemChangedCallback.Invoke();
		}
		return true;
	}
	public void Remove(Item item)
	{
		Items.Remove(item);
		if (onItemChangedCallback != null)
			onItemChangedCallback.Invoke();
	}
}
