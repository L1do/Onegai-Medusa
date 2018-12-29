﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondGearManager : MonoBehaviour {
	public float normalSpeed = 10f;

	public GameObject SpeedBump001;
	public GameObject SpeedBump002;
	public GameObject SpeedBump003;	
	public GameObject StartStage;
	public GameObject RouteSelectStage;
	public GameObject BossStage;
	public GameObject AshibaSet001;
	public GameObject AshibaSet002;
	public GameObject AshibaSet003A;
	public GameObject PoseStage001;
	public GameObject AshibaSet003B;
	public GameObject RouteManager;
	void Awake () {
	AshibaSet001 = GameObject.FindGameObjectWithTag("AshibaSet001");
	AshibaSet002 = GameObject.FindGameObjectWithTag("AshibaSet002");
	PoseStage001 = GameObject.FindGameObjectWithTag("PoseStage001");
	SpeedBump001 = GameObject.FindGameObjectWithTag("SpeedBump001");
	RouteSelectStage = GameObject.FindGameObjectWithTag("RouteSelectStage");
	StartStage = GameObject.FindGameObjectWithTag("StartStage");
	BossStage = GameObject.FindGameObjectWithTag("BossStage");
	AshibaSet003A = GameObject.FindGameObjectWithTag("AshibaSet003A");
	AshibaSet003B = GameObject.FindGameObjectWithTag("AshibaSet003B");	
	RouteManager = GameObject.FindGameObjectWithTag("RouteManager");
	SpeedBump002= GameObject.FindGameObjectWithTag("SpeedBump002");
	SpeedBump003= GameObject.FindGameObjectWithTag("SpeedBump002");
	}

	// Use this for initialization
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	AshibaSet001.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	AshibaSet002.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	PoseStage001.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	SpeedBump001.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	RouteSelectStage.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	StartStage.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	BossStage.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	AshibaSet003A.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	RouteManager.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	SpeedBump002.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	SpeedBump003.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	AshibaSet003B.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
		/*  Vector3 pos = this.gameObject.transform.localPosition;
        pos.z += -1.1f;
        this.gameObject.transform.localPosition = pos;*/
	}
}
