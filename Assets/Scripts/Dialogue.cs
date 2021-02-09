using System.Collections;
using UnityEngine;


[System.Serializable]
public class Dialogue
{
	public string ClerkTalk = "Welcome, most important tool in any adventure is the costume, press [I] to go through yur stuff and change on the change mat.";
	[TextArea(3, 10)]
	public string button1Text ="I'm just checking around";
	[TextArea(3, 10)]
	public string button2Text = "I want to buy something";
}
