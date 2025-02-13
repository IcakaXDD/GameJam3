using TMPro;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    public static LivesManager instance; // Singleton reference
    public int lives = 2; // Shared across all scripts
    public TextMeshProUGUI textMeshProUGUI;
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
    private void Update()
    {
        textMeshProUGUI.text = $"Lives: {lives}";
    }
}
