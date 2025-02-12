using System.Collections.Generic;
using UnityEngine;

public class AnswerChecker : MonoBehaviour
{
    [SerializeField]public int answeredCard;
    [SerializeField] int rightCardId;

    public void CheckAnswer()
    {
        if(answeredCard == rightCardId)
        {
            //load next scene
            Debug.Log("AIDEE");
        }
        else
        {
            // UI Game over
            Debug.Log("Manja s grozde");
        }
    }
    
}
