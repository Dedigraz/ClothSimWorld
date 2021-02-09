using System;
using System.Collections;
using UnityEngine;


public class Wallet : MonoBehaviour
{
	[SerializeField] private int startingFunds;

	public static Wallet Instance;
	public Action Balance;

	private int money;

	private void Awake()
	{
		Instance = this;
	}
	// Use this for initialization
	void Start()
	{
		Add(startingFunds);
	}

	public bool CanAfford(int cost) => money >= cost;

	public void Add(int fund)
	{
		if (fund >0)
		{
			money += fund;
			Balance?.Invoke();
		}
	}

	public void TryWithdraw(int funds)
	{
		if(!CanAfford(funds))
		{
			return;
		}

		money -= funds;
		Balance?.Invoke();
	}
}
