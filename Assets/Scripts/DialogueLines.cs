using UnityEngine;
using TMPro;

public class DialogueLines : MonoBehaviour
{
    [SerializeField] string[] dialogues;
    [SerializeField] TMP_Text dialogueText;

    int current = 0;
    public void NextDialogue()
    {
        current++;

        dialogueText.text = dialogues[current];
    }
}
