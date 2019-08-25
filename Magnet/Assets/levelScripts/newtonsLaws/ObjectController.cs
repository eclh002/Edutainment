using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ObjectController : MonoBehaviour {
	private Rigidbody rb;
	private GameObject s;
	public float pow=2.0f;
	//public Text name = "newton";
	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float x = CrossPlatformInputManager.GetAxis ("Horizontal");
		float y = CrossPlatformInputManager.GetAxis ("Vertical");
		Vector3 mov = new Vector3 (x, 0, y);
	///rb.mass = 1f;
		rb.velocity = mov * 2f;

	}
	void OnCollisionEnter(Collision col)
	{
		Debug.Log ("Collision!");
		if (col.gameObject.name == "box1")
		{
			col.gameObject.GetComponent<Rigidbody>().AddForce (0, pow, 0);
		}
	}


	public void AdjustForce(float newForce){
		pow = newForce;
	}

		
}
