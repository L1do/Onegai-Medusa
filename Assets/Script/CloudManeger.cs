using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudManeger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = this.gameObject.transform.localPosition;
        pos.x += 0.10f;
        this.gameObject.transform.localPosition = pos;
    }
}
