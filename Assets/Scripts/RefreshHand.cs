using UnityEngine;

public class RefreshHand : MonoBehaviour
{
    [SerializeField] GameObject handInGame;
    [SerializeField] GameObject handPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Vector3 handInGamePosition = handInGame.transform.position;
            Quaternion handInGameRotation = handInGame.transform.rotation;
            Destroy(handInGame);
            Instantiate(handPrefab,handInGamePosition, handInGameRotation);
        }
    }
}
