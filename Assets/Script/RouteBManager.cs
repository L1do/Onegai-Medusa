using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteBManager : MonoBehaviour {

	
	public GameObject RouteA;
	public GameObject RouteB;
	public GameObject AshibaSet003A;
	public GameObject AshibaSet003B;
	public GameObject SecondGear;

	// Use this for initialization
	void Awake () {

		RouteA = GameObject.FindGameObjectWithTag("RouteA");
		RouteB = GameObject.FindGameObjectWithTag("RouteB");

		AshibaSet003A = GameObject.FindGameObjectWithTag("AshibaSet003A");
		AshibaSet003B = GameObject.FindGameObjectWithTag("AshibaSet003B");
		SecondGear = GameObject.FindGameObjectWithTag("SecondGear");
	}
	void Start () {
		
//		AshibaSet003A.gameObject.SetActive(false);	
//		AshibaSet003B.gameObject.SetActive(false);	

	}
	
	// Update is called once per frame
	void Update () {
		 if (Input.GetMouseButtonDown(0))
            Debug.Log("Pressed left click.");

	}

		void OnTriggerStay(Collider other)
    {
		  
		Debug.Log ("Route B を選択しました ");
		Destroy(RouteA);
		AshibaSet003B.gameObject.SetActive(true);
		SecondGear.gameObject.SetActive(true);		
		           
    }
}
