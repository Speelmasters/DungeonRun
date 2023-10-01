using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodGenerator : MonoBehaviour
{
    float bobAmount = 0.1f; // Adjust the bobbing height.
    float bobSpeed = 10.0f;  // Adjust the bobbing speed.

    private Vector3 startPos;

    public List<Sprite> sprites;
    public SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr.sprite = sprites[Random.Range(0, sprites.Count)];
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the new Y position based on a sine wave.
        float newY = startPos.y + Mathf.Sin(Time.time * bobSpeed) * bobAmount;

        // Update the item's position.
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
