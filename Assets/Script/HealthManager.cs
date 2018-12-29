using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour {

    public GameManeger gameManager;
    public int startingHealth = 100;
    public int CurrentHealth;
    public int CollisionDamage = 33;
   // public Slider Health;

    

    void Awake()
    {
        
        // Set the initial health of the player.
       CurrentHealth = startingHealth;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDamage(int amount)
    {
       // Reduce the current health by the damage amount.
       CurrentHealth -= amount;

        // Set the health bar's value to the current health.
        //Health.value = CurrentHealth;

        
        if (CurrentHealth <= 0 )
        {
            // ... it should die.
            SceneManager.LoadScene(5);
        }
    }
}
