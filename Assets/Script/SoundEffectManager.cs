using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectManager : MonoBehaviour
{

   // public AudioClip DamageSound;
    AudioSource playerAudio;
    // Use this for initialization


    void Awake()
    {
        // Setting up the references.
        playerAudio = GetComponent<AudioSource>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        // Debug.Log("当たった！！！");

        // Play the hurt sound effect.

        playerAudio.Play();



    }
}
