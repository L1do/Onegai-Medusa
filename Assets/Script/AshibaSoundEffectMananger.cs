using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AshibaSoundEffectMananger : MonoBehaviour {

	public AudioClip badSound; //失敗の音
	public AudioClip goodSound;　//正解の音

	public bool ashibaIsHit = false;
	bool playerKneesAreBending = false;
	bool checkIfPlayerIsInCollider = false;

	private AudioSource soundEffect;

	GameObject Player;


	void Awake ()
	{
		Player = GameObject.FindGameObjectWithTag("Player");
		soundEffect = GetComponent<AudioSource>();

	}

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{

	}

	void OnTriggerEnter(Collider other)
	{
		ashibaIsHit = true;
		checkIfPlayerIsInCollider = true;

		if(checkIfPlayerIsInCollider == true)
		{

			if(other.tag == "Player")
			{

				soundEffect.PlayOneShot(goodSound);
				Debug.LogWarning ("Play badsound");
			}

			else
			{

				soundEffect.PlayOneShot(badSound);
				Debug.LogWarning ("Play goodsound");
			}
		}
	}




}
