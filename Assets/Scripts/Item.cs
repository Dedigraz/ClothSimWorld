using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName ="Store Items",menuName ="Inventory/Store Item")]
public class Item : ScriptableObject
{
	new public string name = "New Item";
	public Sprite icon = null;
	public bool isDefaultItem = false;
}
