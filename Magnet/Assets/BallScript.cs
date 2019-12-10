using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField]
    Animator Texanim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("action");
        Texanim.SetTrigger("animate");
    }
    public void changeGravity(float x)
    {
        this.GetComponent<Rigidbody2D>().gravityScale = x;
    }
}
