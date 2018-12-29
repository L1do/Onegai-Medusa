using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class HannouresultmakerManeger : MonoBehaviour {


    public static int colnumber;
   // Animator GoodText;
   // Animator PerfectText;

    //public Image GoodImage;
    //public Image PerfectImage;
    public float HannouflashSpeed = 40f;
    public Color GoodOpaque= new Color(255f, 239f, 19f, 255f);
    public Color Clear = new Color(0f, 0f, 0f, 0.0f);
    public Color PerfectOpaque = new Color(2f, 113f, 12f, 255f);
    //public Color PerfectClear = new Color(0f, 0f, 0f, 0.0f);


    void Awake()
    {
        // GoodText = GetComponent<Animator>();
        // PerfectText = GetComponent<Animator>();
       


    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {

        
        if (HannouManeger.colnumber <=0 )
        {

        Debug.Log ("PERFECT");
            // PerfectText.SetTrigger("PERFECT");
          //  PerfectImage.color = PerfectOpaque;

        }

        if (HannouManeger.colnumber >= 1)
        {

            Debug.Log("GOOD");
            // GoodText.SetTrigger("GOOD");
          //  GoodImage.color = GoodOpaque;


        }

    }



    void OnTriggerExit(Collider other)
    {

        HannouManeger.colnumber = 0;
   //     PerfectImage.color = Clear;
   //     GoodImage.color = Clear;


    }
}
