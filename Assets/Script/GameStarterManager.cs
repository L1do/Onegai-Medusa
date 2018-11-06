using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
		zeroGear = GameObject.FindGameObjectWithTag("ZeroGear");
		firstGear = GameObject.FindGameObjectWithTag("FirstGear");
		RightHand = GameObject.FindGameObjectWithTag("RightHand");
		LeftHand = GameObject.FindGameObjectWithTag("LeftHand");
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("Start Game");
	}
	void Start () {

			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//void OnTriggerEnter(Collider other)
   // {
	//	Debug.Log ("Start Game");
	//	firstGear.gameObject.SetActive(true);
	//	zeroGear.gameObject.SetActive(false);
		//countTimer = Time.time + 5;

		/*if (countTimer == 0)
            return;
			zeroGear.gameObject.SetActive(true);
			firstGear.gameObject.SetActive(false);

        if (Time.time > countTimer)
        {
            countTimer = 0;
           
        }
        else
        {
            Debug.Log("Counting down " + (countTimer - Time.time));
        }*/

		//Debug.Log ("Start Game");
//		SpeedManager.gameObject.SetActive(true);	
			
		           
  //  }


}
