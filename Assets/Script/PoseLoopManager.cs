using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseLoopManager : MonoBehaviour {

	
	public List<Transform> PoseList;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Transform tf in PoseList)
        {
            if (tf.localPosition.z < -2.0f)
            {

                Vector3 lastPos = PoseList[PoseList.Count - 1].localPosition;
                Vector3 pos = new Vector3(lastPos.x, lastPos.y, lastPos.z +50f);

                tf.localPosition = pos;

                PoseList.RemoveAt(1);
                PoseList.Add(tf);
                break;
            }
        }
		
	}
}
