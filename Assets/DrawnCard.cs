using NUnit.Framework;
using UnityEngine;

public class DrawnCard : MonoBehaviour
{
    //public GameObject[] cards;
    //private float loop;
    //private void Update()
    //{
    //    for (int i = 0; i < 1; i++)
    //    {
    //        loop = Random.Range(0.2f, 0.4f);
    //        float time = Time.time;
    //        if (time > loop)
    //        {
    //            StartAnimation(cards[i]);
    //        }
    //    }
    //}

    public void StartAnimation(GameObject card)
    {
        card.SetActive(true);
    }
}
