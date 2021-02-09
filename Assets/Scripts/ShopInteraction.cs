using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopInteraction : MonoBehaviour
{
	public Animator animator;
	[SerializeField] public Text wallet_Balance;
	//[SerializeField]private Item item1;
	//[SerializeField]private Item item2;
	private Wallet wallet;


	//private void Start()
	//{
	//	Wallet.Instance.GetBalance();
	//}

	private void Start()
	{
		wallet = Wallet.Instance;
	}

	private void Refresh()
	{
		wallet_Balance.text = wallet.GetBalance().ToString(); //Wallet.GetBalance().ToString("N0");
	}
	public void OpenShop()
	{
		FindObjectOfType<DialogueManager>().EndDialogue();
		animator.SetBool("IsRedPill", true);
	}

	public void CloseShop()
	{
		animator.SetBool("IsRedPill", false);
	}

	private void Buy(Item item)
	{
		wallet.TryWithdraw(item.cost);
		Inventory.instance.Add(item);
	}
	//public void BuyItem1()
	//{
	//	wallet.TryWithdraw(item1.cost);
	//	Inventory.instance.Add(item1);
	//	CloseShop();
	//}

	//public void BuyItem2()
	//{
	//	wallet.TryWithdraw(item1.cost);
	//	Inventory.instance.Add(item2);
	//	CloseShop();
	//}
}
