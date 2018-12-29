using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdGearManager : MonoBehaviour {

	public SpeedBumpManager _SpeedManeger;

	public float downSpeed = 1f;
	public float upSpeed = 10f;
	public float normalSpeed = 5f;
	public float noSpeed = 0f;
	public GameObject SpeedBump001;
	//private FirstGearManager speedManager;
	public GameObject AshibaSet001;
	public GameObject AshibaSet002;
	public GameObject PoseStage001;
	public bool collisionDetected = false;

	// Use this for initialization
	void Start () {	
	_SpeedManeger = new SpeedBumpManager();
	//CollisionCheck = new SpeedBumpManager();
	//CollisionCheck.collisionDetected = false;
	//	speedManager = new FirstGearManager();
	//	speedManager.moveSpeed = 5f;
	//speedManager.moveSpeed = 5f;
	AshibaSet001 = GameObject.FindGameObjectWithTag("AshibaSet001");
	AshibaSet002 = GameObject.FindGameObjectWithTag("AshibaSet002");
	PoseStage001 = GameObject.FindGameObjectWithTag("PoseStage001");
	SpeedBump001 = GameObject.FindGameObjectWithTag("SpeedBump001");

	}
	
	// Update is called once per frame
	void Update () {

		AshibaSet001.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
		AshibaSet002.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
		PoseStage001.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
		SpeedBump001.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);

	
	}

	void OnTriggerEnter(Collider other) {

		if( _SpeedManeger.collisionDetected = true){
			Debug.Log ("collision Detected");

		}

		

		//PoseStage001.transform.Translate(-Vector3.forward* downSpeed * Time.deltaTime);
		//AshibaSet002.transform.Translate(-Vector3.forward* downSpeed * Time.deltaTime);
		
	}
	/*	Debug.Log ("you hit a speed bump");
	//	speedManager.moveSpeed = downSpeed;
		PoseStage001.transform.Translate(-Vector3.forward* downSpeed * Time.deltaTime);
		AshibaSet002.transform.Translate(-Vector3.forward* downSpeed * Time.deltaTime);*/
	

}
