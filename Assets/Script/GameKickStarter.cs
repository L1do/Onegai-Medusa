using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameKickStarter : MonoBehaviour {

	GameObject firstGear;

	GameObject zeroGear;
	


	// Use this for initialization
	void Awake ()
	{
		//zeroGear = GameObject.FindGameObjectWithTag("ZeroGear");
		firstGear = GameObject.FindGameObjectWithTag("FirstGear");
	//	RightHand = GameObject.FindGameObjectWithTag("RightHand");
		//LeftHand = GameObject.FindGameObjectWithTag("LeftHand");*/
	}

	
	void Start ()
	 {
		firstGear.gameObject.SetActive(false);
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
   {
	
	firstGear.gameObject.SetActive(true);
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

