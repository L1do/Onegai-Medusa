using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class FloorSpeedManager : MonoBehaviour {

	
	//public bool isHit = false; 
	
	GameObject CubeHolder001;
	GameObject CubeHolder002;
	GameObject CubeHolder003;
	//public float AccelarationSpeed = -0.05f; 
	//public float DecelarationSpeed = -0.05f; 

	

	// Use this for initialization
	void Start () {
	CubeHolder001 = GameObject.FindGameObjectWithTag("CubeHolder001");
	CubeHolder002 = GameObject.FindGameObjectWithTag("CubeHolder002");	
	CubeHolder003 = GameObject.FindGameObjectWithTag("CubeHolder003");

	CubeHolder001.gameObject.SetActive(true);
    CubeHolder002.gameObject.SetActive(false);
    CubeHolder003.gameObject.SetActive(false);
        


	
	 

        
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerExit(Collider other)
    {

        Debug.Log("Speed UP");
        CubeHolder002.gameObject.SetActive(true);
		Destroy(CubeHolder001);
    }


     
	 /* 
	void ChangeSpeed(){

		if(isHit == true){
        
			Vector3 pos = this.gameObject.transform.localPosition;
        	pos.z += 0.50f;
        	this.gameObject.transform.localPosition = pos;

		}
	}*/
}
