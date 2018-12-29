using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeSleepAnimation : MonoBehaviour {
	GameObject Snake;

	void Awake()
	{
		Snake = GameObject.FindGameObjectWithTag("Snake");
	}

	void OnTriggerEnter(Collider other)
	{
		// animation play
		Snake.GetComponent<Animator>().SetTrigger("Sleep");
		Debug.Log("ねむる");
	}


}
