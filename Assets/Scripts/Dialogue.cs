using System.Collections;
using UnityEngine;


[System.Serializable]
public class Dialogue
{
	public string ClerkTalk = "Welcome to our store, what can we do for you";
	[TextArea(3,10)]
	public string[] answers = new string[2] { "I would like to buy something", "I'm just checking"};
}
