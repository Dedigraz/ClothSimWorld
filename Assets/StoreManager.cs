using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreManager : MonoBehaviour
{
	public Item item;
	public Wallet wallet;

	public void PurchaseItem()
	{
		if (wallet.CanAfford(item.cost))
		{
			
		}
	}
}
