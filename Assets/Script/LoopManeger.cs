using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopManeger : MonoBehaviour {

    public List<Transform> ListRailLineTf;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform tf in ListRailLineTf)
        {
            if (tf.localPosition.z < -50.0f)
            {

                Vector3 lastPos = ListRailLineTf[ListRailLineTf.Count - 1].localPosition;
                Vector3 pos = new Vector3(lastPos.x, lastPos.y, lastPos.z +70f);

                tf.localPosition = pos;

                ListRailLineTf.RemoveAt(0);
                ListRailLineTf.Add(tf);
                break;
            }
        }
    }
}
