using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeSleepAgainAnimation : MonoBehaviour {
	GameObject Snake;
	GameObject Frog2;

	void Awake()
	{
		Snake = GameObject.FindGameObjectWithTag("Snake");
		Frog2 = GameObject.FindGameObjectWithTag("Frog2");
	}

	void OnTriggerEnter(Collider other)
	{
		// animation play
		Snake.GetComponent<Animator>().SetTrigger("SleepAgain");
		Debug.Log("ねむる？");

		Frog2.GetComponent<Animator>().SetTrigger("StandardFrog");
		Debug.Log("カエルもどる");
	}


}
