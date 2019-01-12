using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitHitObserve : MonoBehaviour
{
    // イベントハンドラ
    public delegate void OnHitEvent();
    public OnHitEvent OnHit;

    // なにかしらのタグ名をもつオブジェクトと衝突したらTrue
    public bool IsHit = false;
	public string HittingTag = "";
	public string HittingName = "";
	public Animator FloweAnim = null;
	public Renderer AshibasRender = null;

    void Start()
    {
        // 接触判定を初期化
		reset ();
    }

    // Rigidbodyとぶつかった
    void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.tag.StartsWith ("Ashiba") == true) {
			IsHit = true;
			HittingTag = other.gameObject.tag;
			HittingName = other.gameObject.name;
			FloweAnim = (Animator)other.GetComponentInChildren<Animator> ();
			// naosu
			AshibasRender = (Renderer)other.GetComponent<Renderer> ();
			OnHit ();
		} else {
			reset ();
		}
    }

    // Rigidbodyが通過した
    void OnTriggerExit(Collider other)
    {
		reset ();
    }

	void reset()
	{
		IsHit = false;
		HittingTag = "";
		HittingName = "";
		FloweAnim = null;
	}
}
