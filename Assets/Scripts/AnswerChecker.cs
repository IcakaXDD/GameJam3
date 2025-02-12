using System.Collections.Generic;
using UnityEngine;

public class AnswerChecker : MonoBehaviour
{
    [SerializeField] CardManager cardManager;
    [SerializeField] int rightCardId;

    public void CheckAnswer()
    {
        if(cardManager.cardID == rightCardId)
        {
            //load next scene
        }
        else
        {
            // UI Game over
        }
    }
    
}
