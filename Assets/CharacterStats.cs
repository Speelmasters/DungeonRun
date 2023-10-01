using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100;
        currentHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void alterHealth(float amount)
    {
        if(currentHealth + amount > maxHealth) 
        {
            currentHealth = maxHealth;
        }
        else
        {
            currentHealth += amount;
        }
    }



}
