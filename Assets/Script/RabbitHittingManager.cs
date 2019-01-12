using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RabbitHittingManager : MonoBehaviour
{
	[SerializeField]
	RabbitHitObserve Foot_L;

	[SerializeField]
	RabbitHitObserve Foot_R;

	[SerializeField]
	RabbitHitObserve Hand_L;

	[SerializeField]
	RabbitHitObserve Hand_R;

	GameObject Flower;

	public GameObject GoodHannouImage;
	public GameObject BadHannouImage;
	public GameObject GoodHannouSFX;
	public GameObject BadHannouSFX;
	public Material Material;

	void Start()
	{
		//resetHannou ();
		// なにかと衝突したら当たり判定を行う
		Foot_L.OnHit += hitCheck;
		Foot_R.OnHit += hitCheck;
		Hand_L.OnHit += hitCheck;
		Hand_R.OnHit += hitCheck;
	}

	void Awake()
	{
	}


	void hitCheck()
	{
		if (Foot_L.IsHit == false || Foot_R.IsHit == false) {
			return;
		}

		// 両足閉じる【Ashiba_Close】
		if (Foot_L.HittingTag == "Ashiba_Close" && Foot_R.HittingTag == "Ashiba_Close")
		{
			Debug.Log("両足閉じるクリア");
			Debug.Log (Time.time);
			GetComponent<Animator>().SetTrigger("CloseJump");
			Foot_L.AshibasRender.material = Material;
			//Foot_L.FloweAnim.SetTrigger ("ClearFlower");
			//Foot_R.FloweAnim.SetTrigger ("ClearFlower");
			goodHannou();
		}
		if (Foot_L.HittingTag == "Ashiba_Close" && Foot_R.HittingTag != "Ashiba_Close")
		{
			Debug.Log("両足閉じるミス_片足右");
			GetComponent<Animator>().SetTrigger("Miss");
			badHannou();
		}
		if (Foot_L.HittingTag != "Ashiba_Close" && Foot_R.HittingTag == "Ashiba_Close")
		{
			Debug.Log("両足閉じるミス_片足左");
			GetComponent<Animator>().SetTrigger("Miss");
			badHannou();
		}

		// 両足ひらく【Ashiba】
		if (Foot_L.HittingTag == "Ashiba" && Foot_R.HittingTag == "Ashiba")
		{
			Debug.Log("両足ひらくクリア");
			Debug.Log (Time.time);
			GetComponent<Animator>().SetTrigger("Jump");
			goodHannou();
		}
		if (Foot_L.HittingTag == "Ashiba" && Foot_R.HittingTag != "Ashiba")
		{
			Debug.Log("両足ひらくミス_片足右");
			GetComponent<Animator>().SetTrigger("Miss");
			badHannou();
		}
		if (Foot_L.HittingTag != "Ashiba" && Foot_R.HittingTag == "Ashiba")
		{
			Debug.Log("両足ひらくミス_片足左");
			GetComponent<Animator>().SetTrigger("Miss");
			badHannou();
		}
		if (Foot_L.HittingTag == "Ashiba_Miss" && Foot_R.HittingTag == "Ashiba_Miss")
		{
			Debug.Log("両足ひらくミス_両足閉じる");
			GetComponent<Animator>().SetTrigger("Miss");
			badHannou();
		}


		// 片足右【Ashiba_Migi】 
		if (Foot_R.HittingTag == "Ashiba_Migi")
		{
			Debug.Log("片足右クリア");
			Debug.Log (Time.time);
			GetComponent<Animator>().SetTrigger("RightJump");
			goodHannou();
		}
		if (Foot_L.HittingTag != "Ashiba_Hidari" && Foot_R.HittingTag == "Ashiba_Migi")
		{
			Debug.Log("片足右ミス_片足左");
			GetComponent<Animator>().SetTrigger("Miss");
			badHannou();
		}
		if (Foot_L.HittingTag == "Ashiba_Hidari" && Foot_R.HittingTag == "Ashiba_Migi")
		{
			Debug.Log("片足右ミス_両足");
			GetComponent<Animator>().SetTrigger("Miss");
			badHannou();
		}

		// 片足左【Ashiba_Hidari】 
		if (Foot_R.HittingTag == "Ashiba_Hidari")
		{
			Debug.Log("片足左クリア");
			Debug.Log (Time.time);
			GetComponent<Animator>().SetTrigger("LeftJump");
			goodHannou();
		}
		if (Foot_L.HittingTag == "Ashiba_Hidari" && Foot_R.HittingTag != "Ashiba_Migi")
		{
			Debug.Log("片足左ミス_片足右");
			GetComponent<Animator>().SetTrigger("Miss");
			badHannou();
		}
		if (Foot_L.HittingTag == "Ashiba_Hidari" && Foot_R.HittingTag == "Ashiba_Migi")
		{
			Debug.Log("片足左ミス_両足");
			GetComponent<Animator>().SetTrigger("Miss");
			badHannou();
		}
	}
		
	void goodHannou()
	{
		GoodHannouImage.gameObject.SetActive(true);
		GoodHannouSFX.gameObject.SetActive(true);
		BadHannouImage.gameObject.SetActive(false);
		BadHannouSFX.gameObject.SetActive(false);
		Invoke("resetHannou", 1f);
	}

	void badHannou()
	{
		GoodHannouImage.gameObject.SetActive(false);
		GoodHannouSFX.gameObject.SetActive(false);
		BadHannouImage.gameObject.SetActive(true);
		BadHannouSFX.gameObject.SetActive(true);
		Invoke("resetHannou", 1f);
	}

	void resetHannou()
	{
		GoodHannouImage.gameObject.SetActive(false);
		GoodHannouSFX.gameObject.SetActive(false);
		BadHannouImage.gameObject.SetActive(false);
		BadHannouSFX.gameObject.SetActive(false);
	}
}