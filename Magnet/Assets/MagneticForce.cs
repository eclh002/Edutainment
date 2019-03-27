using UnityEngine;
using System.Collections;
public class MagneticForce:MonoBehaviour{

public GameObject Magnet ;
public float forceFactor =10; 
 
void Update () {
 
 var force = (Magnet.transform.position - transform.position) * forceFactor * Time.smoothDeltaTime;
GetComponent<Rigidbody>().AddForce(force);
 
 
}




}
