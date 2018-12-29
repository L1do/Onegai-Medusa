using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManeger : MonoBehaviour
{
    public int colDamage =0;
    GameObject player;
    HealthManager health;
    
    //new code//
    public HannouManeger HannouManeger;

    // public AudioClip DamageClip;
    //AudioSource playerAudio;

    void Awake()
    {
        // Setting up the references.
        player = GameObject.FindGameObjectWithTag("Player");
       health = player.GetComponent<HealthManager>();
       
    }
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
        // ... damage the player.
        //health.TakeDamage(colDamage);
         Debug.Log("当たった！！！");
        //  playerAudio.clip = DamageClip;
        //   playerAudio.Play();
        
        //new code//
        HannouManeger.colnumber += colDamage;

    }
    // void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("当たった！！！");


    // }
}
