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

		if (Foot_L.IsHit == true && Foot_R.IsHit == false) {
			Debug.Log ("左足ぶつかった");
			GetComponent<Animator>().SetTrigger("LeftJump");
		}

		if (Foot_L.IsHit == false && Foot_R.IsHit == true) {
			Debug.Log ("右足ぶつかった");
			GetComponent<Animator>().SetTrigger("RightJump");
		}

		if (Foot_L.IsHit == true && Foot_R.IsHit == true)
		{
			Debug.Log ("両足ぶつかった");
			GetComponent<Animator>().SetTrigger("Jump");
		}
	}
}
