using UnityEngine;
[System.Serializable]
public class Dialogue: MonoBehaviour
{
    [TextArea(3,10)]
    public string[] sentences;
    public AudioClip[] sounds;

    public bool isQuestion;

}
