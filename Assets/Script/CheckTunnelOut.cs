using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTunnelOut : MonoBehaviour {

	public GameManeger gameManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "Player") {
			Debug.Log("トンネル抜けた" + other.gameObject.name);

			Debug.Log ("ぶつかった数" + gameManager.CheckNumCollide ());


			gameManager.ResetAllFlag ();
		}
        
    }

    
}
