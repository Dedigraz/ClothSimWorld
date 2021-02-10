using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
	public Image icon;
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
	public void UseItem(Item item)
	{
		if (item != null)
		{
			ChangeSprite(item);
		}
	}

	//public override void Use()
	//{
	//	base.Use();

	//	ChangeSprite(item);
	//}

	public void ChangeSprite(Item item)
	{
		attireRenderer.sprite = item.Sprite;
	}
}
