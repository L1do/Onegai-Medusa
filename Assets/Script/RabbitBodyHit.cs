using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitBodyHit : MonoBehaviour {

	public delegate void OnHitEvent();
	public OnHitEvent OnHit;

	public bool IsHit = false;

	void Start () {
		IsHit = false;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Ashiba") {
			IsHit = true;
			OnHit ();
		}
	}

	void OnTriggerExit(Collider other)
	{
		IsHit = false;
	}
}
