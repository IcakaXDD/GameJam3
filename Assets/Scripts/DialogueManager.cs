using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour 
{
    public TextMeshProUGUI dialogueText;
    public Dialogue dialogue;
    public Queue<string> sentences;

    public bool isDialogueFinished = false;
    public List<AudioClip> audioNarration;
    private int audioNumber=0;
    public AudioSource audioInPlay;

    public AnswerChecker answerChecker;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sentences = new Queue<string>();
        StartDialogue(dialogue);
        
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (!isDialogueFinished)
            {
                audioNumber++;
                DisplayNextSentence();
            } 
        }
    }
    
    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting conversation");
        isDialogueFinished = false;
        sentences.Clear();
        audioNarration.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        foreach(AudioClip audio in dialogue.sounds)
        {
            audioNarration.Add(audio);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {    

        string sentence = sentences.Dequeue();
        
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        audioInPlay.clip = audioNarration[audioNumber];
        audioInPlay.Play();
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
    }

    public void EndDialogue()
    {
        Debug.Log("EndConvo");
        audioNumber = 0;
        isDialogueFinished= true;
        if (!dialogue.isQuestion)
        {
            answerChecker.CheckAnswer();
        }
    }
    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = " ";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
