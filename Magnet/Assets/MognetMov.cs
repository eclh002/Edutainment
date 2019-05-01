using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MognetMov : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(-CrossPlatformInputManager.GetAxis("Horizontal")/4,0,CrossPlatformInputManager.GetAxis("Vertical")/4));
    }
}
