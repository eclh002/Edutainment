#pragma strict

var Magnet : GameObject;
var forceFactor : float = 10;
 
function Update () {
 
 
 GetComponent.<Rigidbody>().AddForce((Magnet.transform.position - transform.position) * forceFactor * Time.smoothDeltaTime);
 
 
}