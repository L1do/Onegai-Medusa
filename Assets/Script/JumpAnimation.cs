using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAnimation : MonoBehaviour {
	GameObject PlayerRabbit;


	void Awake()
	{
		PlayerRabbit = GameObject.FindGameObjectWithTag("PlayerRabbit");
	}
	void Start ()
	{

	}
	void OnTriggerEnter(Collider other)
	{
		// animation play
		PlayerRabbit.GetComponent<Animator>().SetTrigger("Jump");

		Debug.Log ("animation is playing");

	}


	void Update()
	{

	}
}
