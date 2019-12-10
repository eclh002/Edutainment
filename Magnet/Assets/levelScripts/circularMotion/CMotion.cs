using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CMotion : MonoBehaviour {
	public GameObject center;
	public Text RadiusText;
	//public float  force=20f;
	public float mass= 1f;
	public float rotationSpeed=80f;
	public float radius=2f;
	public float  radiusSpeed=0.5f;

	// Use this for initialization
	void Start () {
		transform.position = (transform.position - center.transform.position).normalized * radius + center.transform.position;

		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.RotateAround (center.transform.position,Vector3.forward,rotationSpeed*Time.deltaTime);
	 var desiredPosition = (transform.position - center.transform.position).normalized * radius + center.transform.position;
		transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * radiusSpeed);
        float force = (mass * rotationSpeed * rotationSpeed) / radius;
        RadiusText.text = "Force acting is " + "" + force.ToString();
        transform.localScale = new Vector3((0.02f+mass/500), (0.02f + mass / 500), (0.02f + mass / 500));
    }
	public void AdjustRadius(float newRadius){
		radius =newRadius;
	}

	public void AdjustMass(float newMass){
		mass=newMass;
	}
	public void AdjustSpeed(float newSpeed){
		rotationSpeed = newSpeed;
	}
}
