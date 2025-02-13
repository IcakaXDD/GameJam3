using UnityEngine;

public class LivesManager : MonoBehaviour
{
    public static LivesManager instance; // Singleton reference
    public int lives = 2; // Shared across all scripts

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Prevents destruction on scene changes
        }
        else
        {
            Destroy(gameObject); // Ensures only one GameManager exists
        }
    }
}
