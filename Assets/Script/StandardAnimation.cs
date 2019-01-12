using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardAnimation : MonoBehaviour {
	GameObject PlayerRabbit;
	GameObject Snake;
	GameObject Frog2;

	void Awake()
	{
		PlayerRabbit = GameObject.FindGameObjectWithTag("PlayerRabbit");
		Snake = GameObject.FindGameObjectWithTag("Snake");
		Frog2 = GameObject.FindGameObjectWithTag("Frog2");
	}

	void OnTriggerEnter(Collider other)
	{
		// animation play
		PlayerRabbit.GetComponent<Animator>().SetTrigger("Standard");
		Debug.Log ("もとにもどる");

		Snake.GetComponent<Animator>().SetTrigger("WakeUp");
		Debug.Log("ヘビ怒る");

		Frog2.GetComponent<Animator>().SetTrigger("Count");
		Debug.Log("カエルカウント");
	}


}
