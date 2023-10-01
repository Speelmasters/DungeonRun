using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionCheck : MonoBehaviour
{

    public CharacterStats cs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the overlapped object has a FoodItem script.
        foodGenerator foodItem = other.GetComponent<foodGenerator>();

        if (foodItem != null)
        {
            cs.alterHealth(5f);
            Destroy(other.gameObject);

        }
    }
}
