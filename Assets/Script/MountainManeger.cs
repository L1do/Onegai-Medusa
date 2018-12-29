using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainManeger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = this.gameObject.transform.localPosition;
        pos.y += 0.01f;
        this.gameObject.transform.localPosition = pos;
    }
}
