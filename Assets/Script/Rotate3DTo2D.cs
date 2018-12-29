using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate3DTo2D : MonoBehaviour {

	public Transform player2d;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion rotate = transform.rotation;
		Vector3 rotate2d = new Vector3();
		rotate2d.y = rotate.x;
		rotate2d.x = rotate.y;
		Debug.Log (rotate.x);
		player2d.Rotate(rotate2d);
	}
}
