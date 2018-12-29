using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseManager : MonoBehaviour {
    public Component  IdleAnim;
    public Component Anim001;
    public Component Anim002;
    public Component Anim003;

    

    // Use this for initialization
  




    void Start () {

     

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {

        Debug.Log("colided");
        IdleAnim.gameObject.SetActive(false);
        Anim001.gameObject.SetActive(true);
        Anim002.gameObject.SetActive(false);
        Anim003.gameObject.SetActive(false);
    }
}
