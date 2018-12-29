using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtariCheckAshiba : MonoBehaviour {

	AtariCheck AtariCheck;

	GameObject GoodHannouSFX;
	GameObject BadHannouSFX;

	
	//bool playerKneesAreBending = false;
	//bool checkIfPlayerIsInCollider = false;

	GameObject Player;

	public Image GoodHannouImage;
	public Image BadHannouImage;

	void Awake()
	{
		AtariCheck = GetComponent("AtariCheck") as AtariCheck;


		GoodHannouSFX = GameObject.FindGameObjectWithTag("GoodHannouSFX");
		BadHannouSFX= GameObject.FindGameObjectWithTag("BadHannouSFX");
		
		Player = GameObject.FindGameObjectWithTag("Player");
	}

	void Start ()
	{
		GoodHannouSFX.gameObject.SetActive(false);
		BadHannouSFX.gameObject.SetActive(false);
		GoodHannouImage.gameObject.SetActive(false);

		if(GoodHannouImage.enabled)
		{
			GoodHannouImage.gameObject.SetActive(false);

		}


	}
	void OnTriggerExit(Collider other)
		{
			GoodHannouImage.gameObject.SetActive(true);
			GoodHannouSFX.gameObject.SetActive(true);
			

			

			
				if(other.tag == "Player" )
				{
					
				//playerKneesAreBending = false;
				//Debug.Log ("The Player is still in the collider");
				
				
				}

		}

	void OnTriggerEnter(Collider other)
	
		{
			GoodHannouImage.gameObject.SetActive(true);
			GoodHannouSFX.gameObject.SetActive(false);
		}	

	

	void Update()
	{
		
//		if(AtariCheck.ashibaIsHit = false)
//		{
//			GoodHannouImage.gameObject.SetActive(false);

//		}

		
	}


}
