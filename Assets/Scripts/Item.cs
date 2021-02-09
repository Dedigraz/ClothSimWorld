using System;
using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName ="Store Items",menuName ="Inventory/Store Item")]
public class Item : ScriptableObject
{
	new public string name = "New Item";
	public Sprite icon = null;
	public bool isDefaultItem = false;
	public int cost = 0;

	public Sprite Sprite = null;
	public virtual void Use()
	{
		//use item
		Debug.Log("using" + name);
	}
}
