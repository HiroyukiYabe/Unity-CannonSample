using UnityEngine;
using System.Collections;

public class Shell : MonoBehaviour {

	GameObject Cannon;

	float InitialVelocity;

	// Use this for initialization
	void Start () {
		Cannon = GameObject.Find("Cannon Base");
		InitialVelocity = 50.0f;
		this.rigidbody.velocity = Cannon.transform.up * InitialVelocity;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
