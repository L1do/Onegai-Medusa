using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtariCheck : MonoBehaviour {

	public bool playerKneesAreBending;

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

		if(other.tag == "Player" )
		{
			playerKneesAreBending = false;
			Debug.Log ("オブジェクトが残っている");
			BadHannouImage.gameObject.SetActive(true);
			
		}

		if(playerKneesAreBending = true)
		{
			Debug.Log ("当たった");	
			GoodHannouImage.gameObject.SetActive(true);
		}

	}

	void OnTriggerExit(Collider other)
	{
		GoodHannouImage.gameObject.SetActive(false);
		BadHannouImage.gameObject.SetActive(false);
	}
	
}
