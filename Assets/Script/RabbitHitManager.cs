using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitHitManager : MonoBehaviour {

	[SerializeField]
	RabbitBodyHit left;

	[SerializeField]
	RabbitBodyHit right;

	void Start () {
		left.OnHit += hitCheck;
		right.OnHit += hitCheck;
	}


	void hitCheck()
	{
		Debug.Log ("RabbitHitManager.hitCheck");

		if (left.IsHit == true && right.IsHit == false) {
			Debug.Log ("左足ぶつかった");
		}

		if (left.IsHit == false && right.IsHit == true) {
			Debug.Log ("右足ぶつかった");
		}

		if (left.IsHit == true && right.IsHit == true)
		{
			Debug.Log ("両足ぶつかった");
			GetComponent<Animator>().SetTrigger("Jump");
		}
	}
}
