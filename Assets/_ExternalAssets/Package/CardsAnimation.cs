using System.Threading;
using UnityEngine;

public class CardsAnimation : MonoBehaviour
{
    public Animator animator;
    public GameObject newCard;
    private float timer = 0;
    public int times = 0;

    private void Start()
    {
        InvokeRepeating("StartAnimation", Random.Range(0.2f, 0.4f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        //timer = Time.time;
        //if(timer > Random.Range(0.2f,0.4f) && times < 2)
        //{
        //    StartAnimation(true);
        //    timer = 0;
        //    times += 1;
        //}
    }

    private void StartAnimation()
    {
        animator.SetTrigger("isTrigger");
    }
}
