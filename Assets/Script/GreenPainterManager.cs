using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPainterManager : MonoBehaviour {
	GameObject GreenPainter;
	Renderer rend002;

	// Use this for initialization
	void Start () {
		Renderer rend002 = GetComponent<Renderer>();

        //Set the main Color of the Material to green
        rend002.material.shader = Shader.Find("_Color");
        rend002.material.SetColor("_Color", Color.blue);

        //Find the Specular shader and change its Color to red
        rend002.material.shader = Shader.Find("Specular");
        rend002.material.SetColor("_SpecColor", Color.blue);
		GreenPainter = GameObject.FindGameObjectWithTag("GreenPainter");
		
	}
	

	void OnTriggerExit(Collider GreenPainter)
    {
	/*	  
		Renderer rend003 = GetComponent<Renderer>();

       	//Set the main Color of the Material to green
        rend003.material.shader = Shader.Find("_Color");
        rend003.material.SetColor("_Color", Color.yellow);

        //Find the Specular shader and change its Color to red
       rend003.material.shader = Shader.Find("Specular");
        rend003.material.SetColor("_SpecColor", Color.yellow);
	 	Debug.Log ("HIT Green");*/
	
		           
    }
}
