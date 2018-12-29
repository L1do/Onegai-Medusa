using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBumpManager : MonoBehaviour {

	//public class Railmaneger;

	public bool collisionDetected = false; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {

		Debug.Log ("you hit a speed bump");
	//	collisionDetected = true; 
		
	}
}
