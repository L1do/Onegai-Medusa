using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHannouImageManager : MonoBehaviour {
	// get all UImages That I need
	public Image GoodHannouImage;
	public Image BadHannouImage;
	// get the script the handles the "Ashiba" Shader

	public bool IsCollided = false;
	public float fadeSpeed = 10f;
	//public AshibaShaderManager AshibaShaderManager;


	
	void Start()
	{
		
		GoodHannouImage.gameObject.SetActive(false);
		BadHannouImage.gameObject.SetActive(false);
	}
	
	void OnTriggerEnter()
	{
		//GoodHannouImage.transform.Translate(Vector2.up* fadeSpeed * Time.deltaTime);
		//BadHannouImage.transform.Translate(Vector2.up* fadeSpeed * Time.deltaTime);

		GoodHannouImage.gameObject.SetActive(true);
		IsCollided = true;

		if(IsCollided = false)
		{
			BadHannouImage.gameObject.SetActive(true);
		}
	}

	void FixedUpdate()
	{
		//GoodHannouImage.transform.Translate(-Vector2.up* fadeSpeed * Time.deltaTime);
		//BadHannouImage.transform.Translate(-Vector2.up* fadeSpeed * Time.deltaTime);

		
	}
}
