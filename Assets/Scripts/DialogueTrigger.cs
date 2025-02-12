using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    private void Start()
    {
        TriggerDialoge();
    }

    public void TriggerDialoge()
    {
        FindFirstObjectByType<DialogueManager>().StartDialogue(dialogue);
    }
}
