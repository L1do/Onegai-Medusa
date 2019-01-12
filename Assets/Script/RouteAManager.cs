using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteAManager : MonoBehaviour {

	public GameObject RouteA;
	public GameObject RouteB;
	public GameObject AshibaSet003A;
	public GameObject AshibaSet003B;
	public GameObject FirstGear;

	// Use this for initialization

	void Awake () {

		RouteA = GameObject.FindGameObjectWithTag("RouteA");
		RouteB = GameObject.FindGameObjectWithTag("RouteB");

		AshibaSet003A = GameObject.FindGameObjectWithTag("AshibaSet003A");
		AshibaSet003B = GameObject.FindGameObjectWithTag("AshibaSet003B");
		FirstGear = GameObject.FindGameObjectWithTag("FirstGear");
	}
	void Start () {
		
//		AshibaSet003A.gameObject.SetActive(false);	
	//	AshibaSet003B.gameObject.SetActive(false);	
	//	FirstGear.gameObject.SetActive(false);
		
		
	}
	
	// Update is called once per frame
	void Update () {
		 if (Input.GetMouseButtonDown(0))
            Debug.Log("Pressed left click.");

	}

		void OnTriggerStay(Collider other)
    {
		  
		Debug.Log ("Route A を選択しました ");
		Destroy(RouteB);
		AshibaSet003A.gameObject.SetActive(true);	
		FirstGear.gameObject.SetActive(true);           
    }
}
