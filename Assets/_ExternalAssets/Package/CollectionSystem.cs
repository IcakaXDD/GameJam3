using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class CollectionSystem : MonoBehaviour
{
    public List<GameObject> cardsDeck = new List<GameObject>();

    // Update is called once per frame
    void Update()
    {
        if(cardsDeck.Count > 0)
        {
            Debug.Log(cardsDeck);
        }
    }

    public void GetCollection(GameObject card)
    {
        cardsDeck.Add(card);
    }
}
