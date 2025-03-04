using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public static int level = 0;
    public List<Dialogue> dialogue;
    public DialogueManager dialogueManager;    
    public int cardID;
    public GameObject textToEnable;
    public AnswerChecker answerChecker;
    private void OnMouseEnter()
    {
        textToEnable.SetActive(true);
    }
    private void OnMouseExit()
    {
        textToEnable.SetActive(false);
    }
    private void OnMouseDown()
    {
        answerChecker.answeredCard = cardID;
        if (dialogueManager.isDialogueFinished)
        {
            dialogueManager.StartDialogue(dialogue[level]);
        }
        
    }
}
