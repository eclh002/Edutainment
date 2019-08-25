using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeController : MonoBehaviour
{
    [SerializeField]
    GameObject other;
    LineRenderer Line;
    // Start is called before the first frame update
    void Start()
    {
        Line = this.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Line.SetPosition(1, other.transform.position);
        Line.SetPosition(0,this.transform.position);
        


    }
}
