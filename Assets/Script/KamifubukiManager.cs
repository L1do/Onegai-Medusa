using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamifubukiManager : MonoBehaviour {

    Animator anim;                              // Reference to the animator component.
    public bool Kamifubukion = false;

    DamageVisualizermanager CollisionDetector;
    public bool collision = false;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        


    }

    void OnTriggerStay(Collider other)
    {
        // Set the damaged flag so the screen will flash.
        // damaged = true;
        // Debug.Log("当たった！！！");
       // DamageImage.color = flashColour;
        // Play the hurt sound effect.
        // playerAudio.Play();
        // Shake.StartCameraShake();

    }
}
