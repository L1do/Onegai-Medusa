using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class DamageVisualizermanager : MonoBehaviour {

   //public CameraShakeManager Shake; 
    public Image DamageImage;    
    public float flashSpeed = 10f;                               
    public Color flashColour = new Color(1f, 0f, 0f,0.1f);
    public Color clearColour = new Color(0f, 0f, 0f, 0.0f);

    //kamigubuki
   // Animator anim;                              // Reference to the animator component.
   // public bool Kamifubukion = false;



    AudioSource playerAudio; 
    // bool damaged;                                              


    void Awake()
    {
     //DamageImage = GameObject.FindGameObjectWithTag("DamageImage");
        playerAudio = GetComponent<AudioSource>();
     

    }


    void Start () {
      DamageImage.color = clearColour;
     
    }

 

    void OnTriggerEnter(Collider other)
    {
 
       DamageImage.color = flashColour;
        // Play the hurt sound effect.
      playerAudio.Play();
 
    }

    void OnTriggerExit(Collider other)
    {
        // Set the damaged flag so the screen will flash.
        // damaged = true;
        
      DamageImage.color = clearColour;
 

        //kamigubuki
        //anim.SetTrigger("抜けた");
        



    }
}
