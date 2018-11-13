using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtariCheck : MonoBehaviour {

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
	void OnTriggerEnter(Collider other)
	{
		//colliderIsEmpty = false;
		checkIfPlayerIsInCollider = true;

		

		if(checkIfPlayerIsInCollider = true)
		{
			if(other.tag == "Player" )
			{
				
			playerKneesAreBending = false;
			Debug.Log ("The Player is still in the collider");
			BadHannouImage.gameObject.SetActive(true);
			
			}
			else
			{
				playerKneesAreBending = true;
				
		}

		
			
		}



	}

	public void CheckPlayer()
	{
		if(playerKneesAreBending = true)
			{

			Debug.Log ("The Player is outside the collider");	
			GoodHannouImage.gameObject.SetActive(true);
			}
	}

	void Update()
	{
		
		

		
	}

	void OnTriggerExit(Collider other)
	{
		checkIfPlayerIsInCollider = false;

		GoodHannouImage.gameObject.SetActive(false);
		BadHannouImage.gameObject.SetActive(false);
	}
	
}
