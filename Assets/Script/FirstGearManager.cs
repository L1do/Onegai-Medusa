using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstGearManager : MonoBehaviour {
	public float normalSpeed = 5f;

	//public float moveSpeed = 5f;
	public GameObject SpeedBump001;
	public GameObject SpeedBump002;
	public GameObject SpeedBump003;
	//private FirstGearManager speedManager;
	public GameObject StartStage;
	public GameObject RouteSelectStage;
	public GameObject BossStage;
	public GameObject AshibaSet001;
	public GameObject AshibaSet002;

	public GameObject AshibaSet003A;
	public GameObject AshibaSet003B;

	public GameObject PoseStage001;
	public GameObject PoseStage002;
	public GameObject PoseStage003;

	public GameObject RouteManager;

	public GameObject FinishLine;
	
	// Use this for initialization
	void Awake () {
	AshibaSet001 = GameObject.FindGameObjectWithTag("AshibaSet001");
	AshibaSet002 = GameObject.FindGameObjectWithTag("AshibaSet002");

	PoseStage001 = GameObject.FindGameObjectWithTag("PoseStage001");
	PoseStage002 = GameObject.FindGameObjectWithTag("PoseStage002");
	PoseStage003 = GameObject.FindGameObjectWithTag("PoseStage003");

	SpeedBump001 = GameObject.FindGameObjectWithTag("SpeedBump001");
	SpeedBump002= GameObject.FindGameObjectWithTag("SpeedBump002");
	SpeedBump003= GameObject.FindGameObjectWithTag("SpeedBump003");

	RouteSelectStage = GameObject.FindGameObjectWithTag("RouteSelectStage");
	StartStage = GameObject.FindGameObjectWithTag("StartStage");
	BossStage = GameObject.FindGameObjectWithTag("BossStage");
	AshibaSet003A = GameObject.FindGameObjectWithTag("AshibaSet003A");
	AshibaSet003B = GameObject.FindGameObjectWithTag("AshibaSet003B");
	RouteManager = GameObject.FindGameObjectWithTag("RouteManager");

	FinishLine = GameObject.FindGameObjectWithTag("FinishLine");
	
	}
	void Start () {
		 
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	 /*Vector3 pos = this.gameObject.transform.localPosition;
        pos.z += -0.1f;
        this.gameObject.transform.localPosition = pos;*/

	AshibaSet001.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	//AshibaSet002.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);

	PoseStage001.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	PoseStage002.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	PoseStage003.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);

	SpeedBump001.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	SpeedBump002.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	SpeedBump003.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);

	//RouteSelectStage.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	StartStage.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	//BossStage.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	//AshibaSet003A.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	//RouteManager.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	//AshibaSet003B.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	
	FinishLine.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	
	}
}
