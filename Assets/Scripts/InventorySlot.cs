using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : Item
{
	new public Image icon;
	public SpriteRenderer attireRenderer;
	Item item;
	public void AddItem(Item newItem)
	{
		item = newItem;
		icon.sprite = item.icon;
		icon.enabled = true;
	}

	public void ClearSlot() 
	{
		item = null;
		icon.sprite = null;
		icon.enabled = false;
	}
	public void UseItem()
	{
		if (item != null)
		{
			item.Use();
		}
	}

	public override void Use()
	{
		base.Use();

		ChangeSprite(item);
	}

	public void ChangeSprite(Item item)
	{
		attireRenderer.sprite = item.Sprite;
	}
}
