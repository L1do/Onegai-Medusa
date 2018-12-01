using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAnimationManeger : MonoBehaviour {

	// Animations

	GameObject playerRabbit;
	public Animation jump;
	
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
			Player.GetComponent<Animator>().SetTrigger("Jump");
				
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


	void Update()
	{

	}

	
	
}
