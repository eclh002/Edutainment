using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endscript : MonoBehaviour
{
    public magnetscript magscript;
     void OnTriggerEnter(Collider other)
    {
        
            Debug.Log("entered");
        magscript.line2();
        
    }   
}
