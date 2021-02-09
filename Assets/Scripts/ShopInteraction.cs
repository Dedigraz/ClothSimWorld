using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopInteraction : MonoBehaviour
{
	public Animator animator;
	public Wallet Wallet;
	public Text wallet_Balance;

	private void Start()
	{
		Wallet = Wallet.Instance;
		wallet_Balance.text = Wallet.money.ToString();
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
}
