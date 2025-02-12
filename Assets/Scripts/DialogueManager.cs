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


    public List<AudioClip> audioNarration;
    private int audioNumber=0;
    public AudioSource audioInPlay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sentences = new Queue<string>();
        TriggerDialoge();
        
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            audioNumber++;
            DisplayNextSentence();
            
        }
    }
    public void TriggerDialoge()
    {
        StartDialogue(dialogue);
    }
    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting conversation");

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
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        
        
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        audioInPlay.clip = audioNarration[audioNumber];
        audioInPlay.Play();
    }

    public void EndDialogue()
    {
        Debug.Log("EndConvo");
        audioNumber = 0;
    }
    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = " ";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
}
