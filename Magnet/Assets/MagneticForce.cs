using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class MagneticForce:MonoBehaviour{

public GameObject Magnet ;
    float forceFactor;
   
 
void Update () {
       
 var force = (Magnet.transform.position - transform.position) * forceFactor * Time.smoothDeltaTime;
GetComponent<Rigidbody>().AddForce(force);
 
 
}




}
