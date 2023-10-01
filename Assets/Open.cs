using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Open : MonoBehaviour
{
    public LayerMask tilemapLayer; // Set this in the Inspector to specify the Tilemap layer.
    public Tilemap tm;

    private bool isFading = false;
    private float lerpDuration = 0.5f; // Adjust the duration of the fade here.
    private float currentLerpTime = 0f;
    private Color initialColor;
    private Color targetColor;

    private void Update()
    {
        if (isFading)
        {
            // Calculate the lerp progress.
            currentLerpTime += Time.deltaTime;
            float t = currentLerpTime / lerpDuration;

            // Lerp the alpha value.
            Color lerpedColor = Color.Lerp(initialColor, targetColor, t);
            tm.color = lerpedColor;

            if (t >= 1.0f)
            {
                // The fade is complete.
                isFading = false;
            }
        }
        
    }

    private void FadeOut()
    {
        isFading = true;
        currentLerpTime = 0f;
        initialColor = tm.color;
        targetColor = new Color(initialColor.r, initialColor.g, initialColor.b, 0f); // Set the target alpha to 0.
    }


    private void FadeIn()
    {
        isFading = true;
        currentLerpTime = 0f;
        initialColor = tm.color;
        targetColor = new Color(initialColor.r, initialColor.g, initialColor.b, 1f); // Set the target alpha to 0.
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FadeOut();
    }
}
