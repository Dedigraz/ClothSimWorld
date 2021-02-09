using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreUI : MonoBehaviour
{
	public Item item;
	public Text nameText;
	public Image icon;
	public Text priceText;
	private Wallet wallet;
	

	void Start()
	{
		nameText.text = item.name;
		priceText.text = item.cost.ToString();
		icon.sprite = item.icon;
	}
	
	
}
