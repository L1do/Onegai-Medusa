using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtariCheckAshiba : MonoBehaviour {

	
	bool playerKneesAreBending = false;
	bool checkIfPlayerIsInCollider = false;

	GameObject Player;

	public Image GoodHannouImage;
	public Image BadHannouImage;

	void Awake()
	{
		Player = GameObject.FindGameObjectWithTag("Player");
	}

	void Start ()
	{

		GoodHannouImage.gameObject.SetActive(false);
		BadHannouImage.gameObject.SetActive(false);
	}
	void OnTriggerExit(Collider other)
	{
		//colliderIsEmpty = false;
		//checkIfPlayerIsInCollider = true;

		

		
			if(other.tag == "Player" )
			{
				
			//playerKneesAreBending = false;
			//Debug.Log ("The Player is still in the collider");
			GoodHannouImage.gameObject.SetActive(true);
			
			}
			
		
			
		



	}

	

	void Update()
	{
		
		

		
	}


}
