using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
	//private Queue<string> sentences;
	//// Start is called before the first frame update
	//void Start()
	//{
	//	sentences = new Queue<string>();
	//}
	public Text DialogueText;
	public Text button1;
	public Text button2;
	public Animator Animator;
	public void StartDialogue(Dialogue dialogue)
	{
		Animator.SetBool("IsOpen", true);
		Debug.Log("Starting conversation with clerk");

		DialogueText.text = dialogue.ClerkTalk;
		button1.text = dialogue.button1Text;
		button2.text = dialogue.button2Text;
		return;
	}
	
	public void EndDialogue()
	{
		Animator.SetBool("IsOpen", false);
		Debug.Log("End of conversation");
	}
}
