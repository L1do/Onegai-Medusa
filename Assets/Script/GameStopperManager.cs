using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStopperManager : MonoBehaviour {

	GameObject SpeedManager;

	// Use this for initialization
	void Awake (){

		SpeedManager = GameObject.FindGameObjectWithTag("SpeedManager");
	}
	void Start () {

	//	SpeedManager.gameObject.SetActive(false);		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
    {
		  
		Debug.Log ("Stopper Game");
		SpeedManager.gameObject.SetActive(false);	
			
		           
    }
}
