using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;
public class box1change: MonoBehaviour {
	private Rigidbody rb1;
		
	// Use this for initialization
	void Start () {

		rb1 = GetComponent<Rigidbody> ();
        rb1.mass = 2f;
    }

	// Update is called once per frame
	void Update () {
		
		
			}
	public void AdjustMass(float newMass){
		rb1.mass = newMass;
	}
}