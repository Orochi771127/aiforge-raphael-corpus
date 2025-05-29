using UnityEngine;
using TMPro;

public class DialogueBubbleUI  MonoBehaviour
{
    public TextMeshProUGUI dialogueText;

    public void DisplayDialogue(string text)
    {
        dialogueText.text = text;
    }
}