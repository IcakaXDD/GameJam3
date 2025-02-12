
using UnityEngine;

public class DetachChild : MonoBehaviour
{
    [SerializeField] GameObject hand;
   
    private void OnMouseDown()
    {
        if (gameObject.transform.parent == null)
        {
            return;
        }
        else
        {
            
            Vector3 childPosition = gameObject.transform.position;
            gameObject.transform.parent = null;
            gameObject.transform.position = childPosition;
        }
    }
}
