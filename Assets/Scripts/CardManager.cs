using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public static int level = 0;
    public List<Dialogue> dialogue;
    public DialogueManager dialogueManager;

    private void OnMouseDown()
    {
        if (dialogueManager.isDialogueFinished)
        {
            dialogueManager.StartDialogue(dialogue[level]);
            level++;
        }
        
    }
}
