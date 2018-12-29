using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarterManager : MonoBehaviour {

	GameObject RightHand;
	GameObject LeftHand;
	GameObject SpeedManager;

	GameObject firstGear;

	GameObject zeroGear;
	float countTimer = 0;


	// Use this for initialization
	void Awake ()
	{
	/* 	zeroGear = GameObject.FindGameObjectWithTag("ZeroGear");
		firstGear = GameObject.FindGameObjectWithTag("FirstGear");
		RightHand = GameObject.FindGameObjectWithTag("RightHand");
		LeftHand = GameObject.FindGameObjectWithTag("LeftHand");*/
	}

	
	void Start ()
	 {
		countTimer = Time.time + 5;
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
   {
	Debug.Log ("Change Scene");
	SceneManager.LoadScene(1);
	//firstGear.gameObject.SetActive(true);
	//zeroGear.gameObject.SetActive(false);
		

		/* if (countTimer == 0)
            return;
			

        if (Time.time > countTimer)
        {
        	countTimer = 0;
           	zeroGear.gameObject.SetActive(false);
			firstGear.gameObject.SetActive(true);
        }
        else
        {
            Debug.Log("Counting down " + (countTimer - Time.time));
        }*/

		//Debug.Log ("Start Game");
//		SpeedManager.gameObject.SetActive(true);	
			
		           
 	}


}
