using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitHitManager : MonoBehaviour {

	[SerializeField]
	RabbitBodyHit Foot_L;

	[SerializeField]
	RabbitBodyHit Foot_R;

	[SerializeField]
	RabbitBodyHit Hand_L;

	[SerializeField]
	RabbitBodyHit Hand_R;

	void Start () {
		Foot_L.OnHit += hitCheck;
		Foot_R.OnHit += hitCheck;
		Hand_L.OnHit += hitCheck;
		Hand_R.OnHit += hitCheck;
	}


	void hitCheck()
	{
		Debug.Log ("RabbitHitManager.hitCheck");

		if (Foot_L.IsHit == true && Foot_R.IsHit == false/* && Hand_L.IsHit == true && Hand_R.IsHit == true*/) {
			Debug.Log ("左足クリア");
			GetComponent<Animator>().SetTrigger("LeftJump");
		}
			
		if (Foot_L.IsHit == false && Foot_R.IsHit == true/* && Hand_L.IsHit == true && Hand_R.IsHit == true*/) {
			Debug.Log ("右足クリア");
			GetComponent<Animator>().SetTrigger("RightJump");
		}

		if (Foot_L.IsHit == true && Foot_R.IsHit == true/* && Hand_L.IsHit == true && Hand_R.IsHit == true*/)
		{
			Debug.Log ("両足クリア");
			GetComponent<Animator>().SetTrigger("Jump");
		}

		/*if (Foot_L.IsHit == true && Foot_R.IsHit == false && Hand_L.IsHit == false && Hand_R.IsHit == false) {
			Debug.Log ("左足ミス");
			GetComponent<Animator>().SetTrigger("");
		}

		if (Foot_L.IsHit == true && Foot_R.IsHit == false && Hand_L.IsHit == false && Hand_R.IsHit == false) {
			Debug.Log ("左足ミス");
			GetComponent<Animator>().SetTrigger("");
		}

		if (Foot_L.IsHit == true && Foot_R.IsHit == true && Hand_L.IsHit == false && Hand_R.IsHit == false) {
			Debug.Log ("両足ミス");
			GetComponent<Animator>().SetTrigger("");
		}*/
	}
}
