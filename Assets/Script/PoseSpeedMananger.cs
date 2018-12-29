using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseSpeedMananger : MonoBehaviour {
	//ポーズのスピードを管理する関数。
	public float poseSpeed = 5f;

	//ポーズの当たり判定。
	GameObject poseHolder;
	
	void Awake()
	{   
		////ポーズの当たり判定をタグで取得。
		poseHolder = GameObject.FindGameObjectWithTag("PoseHolder");
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		poseHolder.transform.Translate(-Vector3.forward* poseSpeed * Time.deltaTime);

		//↓不要なスクリプト
		// Vector3 pos = this.gameObject.transform.localPosition;
        // pos.z += -0.22f;
        // this.gameObject.transform.localPosition = pos;
	}
}
