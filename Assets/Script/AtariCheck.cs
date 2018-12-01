using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtariCheck : MonoBehaviour {

	bool playerKneesAreBending = false;
	bool checkIfPlayerIsInCollider = false;
	public bool ashibaIsHit = false;

	GameObject Player;

	public Image GoodHannouImage;
	public Image BadHannouImage;

	GameObject GoodHannouSFX;
	GameObject BadHannouSFX;


	void Awake()
	{
		GoodHannouSFX = GameObject.FindGameObjectWithTag("GoodHannouSFX");
		BadHannouSFX= GameObject.FindGameObjectWithTag("BadHannouSFX");

		Player = GameObject.FindGameObjectWithTag("Player");
	}

	void Start ()
	{
		GoodHannouSFX.gameObject.SetActive(false);
		BadHannouSFX.gameObject.SetActive(false);

		GoodHannouImage.gameObject.SetActive(false);
		BadHannouImage.gameObject.SetActive(false);
	}
	void OnTriggerEnter(Collider other)
	{
		ashibaIsHit = true;
		//colliderIsEmpty = false;
		checkIfPlayerIsInCollider = true;

		

		if(checkIfPlayerIsInCollider == true)
		{
			if(other.tag == "Player" )
			{
				// animation play
				//Player.GetComponent<Animator>().SetTrigger("Jump");
				
			playerKneesAreBending = false;
			Debug.Log ("The Player is still in the collider");
			BadHannouImage.gameObject.SetActive(true);
			BadHannouSFX.gameObject.SetActive(true);
			}
			else
			{
				playerKneesAreBending = true;
				
		}

		
			
		}



	}

	/* public void CheckForCollision()
	{
		if(playerKneesAreBending = true)
			{

			Debug.Log ("The Player is outside the collider");	
			GoodHannouImage.gameObject.SetActive(true);
			}
	}*/

	void Update()
	{
		
		

		
	}

	void OnTriggerExit(Collider other)
	{
		ashibaIsHit = false;
		checkIfPlayerIsInCollider = false;

		GoodHannouImage.gameObject.SetActive(false);
		BadHannouImage.gameObject.SetActive(false);
		BadHannouSFX.gameObject.SetActive(false);
	}
	
}
