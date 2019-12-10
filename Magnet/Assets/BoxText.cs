using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxText : MonoBehaviour
{
    Rigidbody rbd;
    [SerializeField]
    TextMesh textMesh;
   
    // Start is called before the first frame update
    void Start()
    {
        rbd = this.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (rbd.velocity.x > 0 || rbd.velocity.y > 0 || rbd.velocity.z > 0)
        {
            textMesh.text = "OBJECT IS IN MOTION";
        }
        else {
            textMesh.text = "OBJECT IS AT REST";
        }
    }
}
