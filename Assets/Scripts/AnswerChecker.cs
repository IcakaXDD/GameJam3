using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnswerChecker : MonoBehaviour
{
    [SerializeField]public int answeredCard;
    [SerializeField] int rightCardId;
    [SerializeField] string sceneName;
    public static int lives = 3;
    public void CheckAnswer()
    {
        if(answeredCard == rightCardId)
        {
            SceneManager.LoadScene(sceneName);
        }
        else if (answeredCard != rightCardId && lives > 0)
        {
            lives--;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            lives = 3;
            SceneManager.LoadScene("TitleScreen");
        }
    }
    
}
