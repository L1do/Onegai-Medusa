using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GameReset : MonoBehaviour {



void OnTriggerStay(Collider other)
	{

		SceneManager.LoadScene(0);	

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
