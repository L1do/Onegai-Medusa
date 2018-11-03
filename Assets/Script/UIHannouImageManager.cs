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

	public AshibaShaderManager AshibaShaderManager;


	
	void Awake()
	{
		
		GoodHannouImage.gameObject.SetActive(false);
		BadHannouImage.gameObject.SetActive(false);
	}
	
	void Update()
	{
		if(IsCollided = true)
		{
			GoodHannouImage.gameObject.SetActive(true);
			
		}
		else if(IsCollided = true)
		{
			BadHannouImage.gameObject.SetActive(true);
			
		}
	}
}
