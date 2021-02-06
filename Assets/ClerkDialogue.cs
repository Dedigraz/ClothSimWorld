using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClerkDialogue : MonoBehaviour
{
	public Dialogue dialogue;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log("Yas");
		TriggerDialogue();
	}
	public void TriggerDialogue()
	{

		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
	}
}
