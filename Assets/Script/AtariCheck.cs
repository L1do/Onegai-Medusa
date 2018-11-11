using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtariCheck : MonoBehaviour {

	public bool isHit = false;



	void Start () {

		//isNotHit = true;


		
	}


	void onTriggerEnter()
	{

	}

	void onTriggerStay()
	{

	}

	void OnTriggerExit()
	{
		isHit = true;

		if(isHit = true)
		{
			Debug.Log ("オブジェクトが残っている");


		}

		Debug.Log ("当たらなかった");
		//isHit = false;

		//if(isNotHit = false)
		//{
		//	Debug.Log ("当たらなかった");


		//}

		


		//Debug.Log ("当たった!");
	}

	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
		
		
	}
}
