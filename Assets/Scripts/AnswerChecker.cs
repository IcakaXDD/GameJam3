using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnswerChecker : MonoBehaviour
{
    [SerializeField]public int answeredCard;
    [SerializeField] int rightCardId;
    [SerializeField] string sceneName;
    public void CheckAnswer()
    {
        if (LivesManager.instance.lives <= 0)
        {
            LivesManager.instance.lives = 2; // Reset on game over
            SceneManager.LoadScene("GameOver");
            return;
        }

        if (answeredCard == rightCardId)
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            LivesManager.instance.lives--;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    
}
