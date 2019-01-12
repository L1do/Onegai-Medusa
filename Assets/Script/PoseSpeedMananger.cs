using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseSpeedMananger : MonoBehaviour {
	//ポーズのスピードを管理する関数。
	public float poseSpeed = 0.15f;

	//ポーズの当たり判定。
	public GameObject poseHolder001;
	public GameObject poseHolder002;
	public GameObject poseHolder003;

	public GameObject JumpStarter001;
	public GameObject JumpStarter002;
	public GameObject JumpStarter003;
	
	void Awake()
	{   
		////ポーズの当たり判定をタグで取得。
		poseHolder001 = GameObject.FindGameObjectWithTag("PoseHolder001");
		poseHolder002 = GameObject.FindGameObjectWithTag("PoseHolder002");
		poseHolder003 = GameObject.FindGameObjectWithTag("PoseHolder003");

		JumpStarter001 = GameObject.FindGameObjectWithTag("JumpStarter001");
		JumpStarter002 = GameObject.FindGameObjectWithTag("JumpStarter002");
		JumpStarter003 = GameObject.FindGameObjectWithTag("JumpStarter003");
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		poseHolder001.transform.Translate(-Vector3.forward* poseSpeed * Time.deltaTime);
		poseHolder002.transform.Translate(-Vector3.forward* poseSpeed * Time.deltaTime);
		poseHolder003.transform.Translate(-Vector3.forward* poseSpeed * Time.deltaTime);

		JumpStarter001.transform.Translate(-Vector3.forward* poseSpeed * Time.deltaTime);
		JumpStarter002.transform.Translate(-Vector3.forward* poseSpeed * Time.deltaTime);
		JumpStarter003.transform.Translate(-Vector3.forward* poseSpeed * Time.deltaTime);

	}
}
