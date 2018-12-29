using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartManager : MonoBehaviour {
	public GameObject firstGear;
	public GameObject secondGear;
	public GameObject zeroGear;
	public GameObject SpeedBump001;
	public GameObject AshibaSet001;
	public GameObject AshibaSet002;
	public GameObject PoseStage001;
	public GameObject PoseStage002;
	
	// find and attach componets using tags.
	void Awake () 
	{
		AshibaSet001 = GameObject.FindGameObjectWithTag("AshibaSet001");
		AshibaSet002 = GameObject.FindGameObjectWithTag("AshibaSet002");
		PoseStage001 = GameObject.FindGameObjectWithTag("PoseStage001");
		SpeedBump001 = GameObject.FindGameObjectWithTag("SpeedBump001");
		PoseStage002 = GameObject.FindGameObjectWithTag("PoseStage002");

		firstGear = GameObject.FindGameObjectWithTag("FirstGear");
		secondGear = GameObject.FindGameObjectWithTag("SecondGear");
		zeroGear = GameObject.FindGameObjectWithTag("ZeroGear");
	}
	// Use this for initialization
	void Start () 
	{
		
	}
	
	//when other colliders enter this object the floor moves 
	void OnTriggerStay(Collider other) 
	{

//		Debug.Log ("Start floor Again");	
		zeroGear.gameObject.SetActive(false);
		firstGear.gameObject.SetActive(true);	
			

	}
}
