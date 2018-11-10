using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour {
	public GameObject firstGear;
	public GameObject secondGear;
	public GameObject zeroGear;

	//fetch components using tags.
	void Awake () 
	{
		firstGear = GameObject.FindGameObjectWithTag("FirstGear");
		secondGear = GameObject.FindGameObjectWithTag("SecondGear");
		zeroGear = GameObject.FindGameObjectWithTag("ZeroGear");
	}

	//move floor using the speed that is set on the "FirstGear" Gameobject.
	void Start () 
	{
		firstGear.gameObject.SetActive(false);
		secondGear.gameObject.SetActive(false);
		zeroGear.gameObject.SetActive(false);	
	}

	//when other collider enter this object, the Floor stop moving and this object's Box Collider is removed.
	void OnTriggerStay(Collider other)
	{

		Debug.Log ("Stop floor!");	
		zeroGear.gameObject.SetActive(true);
		firstGear.gameObject.SetActive(false);	
		Destroy(GetComponent<BoxCollider>());		

	}



}
