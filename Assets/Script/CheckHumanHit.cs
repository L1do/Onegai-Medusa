using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckHumanHit : MonoBehaviour {

    public bool IsHit = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other) {
		string name = LayerMask.LayerToName (other.gameObject.layer);
		if (name == "TunnelBatsu") {
			IsHit = true;
		}
    }

	public void ResetFlag(){
		IsHit = false;
	}
}
