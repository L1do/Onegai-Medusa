﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pose003maneger : MonoBehaviour {

    public Component IdleAnim;
    public Component Anim001;
    public Component Anim002;
    public Component Anim003;



    // Use this for initialization





    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        Debug.Log("colided");
        IdleAnim.gameObject.SetActive(false);
        Anim003.gameObject.SetActive(true);
        Anim001.gameObject.SetActive(false);
        Anim002.gameObject.SetActive(false);
    }
}