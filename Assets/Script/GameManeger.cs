using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;


public class GameManeger : MonoBehaviour {

	public List<CheckHumanHit> ListCheckScripts;
    



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
		
	}

   public int CheckNumCollide()
    {
        int cnt = 0;
        foreach (CheckHumanHit humanHit in ListCheckScripts)
        {
            if (humanHit.IsHit)
            {
                cnt++;
            }
        }
        return cnt;

        


    }


    

    public void ResetAllFlag() {
		foreach(CheckHumanHit humanHit in ListCheckScripts) {
			humanHit.ResetFlag ();
		}
	}
}
