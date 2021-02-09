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
	private Inventory inventory;
	public Animator Animator;

	void Start()
	{
		wallet = Wallet.Instance;
		nameText.text = item.name;
		priceText.text = item.cost.ToString();
		icon.sprite = item.icon;
	}
	
	void BuyItem()
	{
		wallet.TryWithdraw(item.cost);
		inventory.Add(item);
	}
}
