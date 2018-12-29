using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UserInterfaceManager : MonoBehaviour {

	//all the UI Image that I will use below

	//public Image StartImage;
	public Image FinishImage;
	//public Text FinishText;
	Text CountDownNumber; 
	Color finishColour = new Color(255f, 255f, 255f,255f);
	//Color finishTextColour = new Color(50f, 50f, 50f,255f);
    //public Color normalColour = new Color(0f, 0f, 0f, 0.0f);
	void Awake()
	{
		//FinishText = gameObject.FindGameObjectWithTag("FinishText");
	}

	void Start()
	{
		//FinishText.gameObject.SetActive(false);

	}

	void OnTriggerEnter(Collider other)
    {
      //when the game ends show the stage clear scene 
       FinishImage.color = finishColour;
	   //FinishText.color = finishTextColour;
	   //FinishText.gameObject.SetActive(true);
	         
    }

    


	
}
