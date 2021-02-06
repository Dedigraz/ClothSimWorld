using System.Collections;
using UnityEngine;


[System.Serializable]
public class Dialogue
{
	public string ClerkTalk = "Welcome to our store, what can we do for you";
	[TextArea(3, 10)]
	public string button1Text ="I'm just checking around";
	[TextArea(3, 10)]
	public string button2Text = "I want to buy something";
}
