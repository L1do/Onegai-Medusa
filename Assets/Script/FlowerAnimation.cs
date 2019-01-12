using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerAnimation : MonoBehaviour {
	GameObject Flower;

	void Awake()
	{
		Flower = GameObject.FindGameObjectWithTag("Flower");
	}

	void OnTriggerEnter(Collider other)
	{
		// animation play
		Flower.GetComponent<Animator>().SetTrigger("ClearFlower");
		Debug.Log("花が咲く");
	}


}
