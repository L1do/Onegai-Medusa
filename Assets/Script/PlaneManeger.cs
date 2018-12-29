using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneManeger : MonoBehaviour {

    public float thrust;
    public Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    void Update()
    {
        rb.AddForce(0f, 0f, -20f);


    }
}
