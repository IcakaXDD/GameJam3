using JetBrains.Annotations;
using UnityEngine;

public class KingScript : MonoBehaviour
{
    public CollectionSystem collect;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Queen"))
        {
            collect.GetCollection(transform.gameObject);
        }
    }
}
