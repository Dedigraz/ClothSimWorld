using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClerkDialogue : MonoBehaviour
{
	public Dialogue dialogue;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("Yas");
		TriggerDialogue();
	}
	private void OnTriggerExit2D(Collider2D collision)
	{
		FindObjectOfType<DialogueManager>().EndDialogue();
	}
	public void TriggerDialogue()
	{

		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
	}
}
