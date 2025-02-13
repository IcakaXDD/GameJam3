using UnityEngine;

public class FinalAnimationTrigger : MonoBehaviour
{
    public DialogueManager dialogueManager;
    public Animator animator;
    private bool playedAnimation = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogueManager.isDialogueFinished)
        {
            if (!playedAnimation) 
            {
                animator.SetBool("PlayAnimation", true);
                playedAnimation = true; 
            }
        }
    }
}
