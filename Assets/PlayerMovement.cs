using System.Collections;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float distance = 1.0f;

    public int column = 3;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    // Lerp Movement
    private Vector3 endPos;
    private Vector3 startPos;
    private float desiredDuration = 0.1f;
    private float elapsedTime = 0.1f;

    private void Start()
    {
        endPos = rb.transform.position;
        movement.y = 0.15f;

    }

    void Update()
    {
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    public void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement);

        if (elapsedTime < desiredDuration)
        {
            elapsedTime += Time.fixedDeltaTime;
            float percentageComplete = elapsedTime / desiredDuration;
            
            rb.MovePosition(new Vector2(Mathf.Lerp(startPos.x, endPos.x, percentageComplete), Mathf.Lerp(startPos.y, endPos.y, percentageComplete))); //rb.position.y
        }
    }

    public void moveRight()
    {
        if (column < 5)
        {
            column++;
            Debug.Log("right");
            startLerp(distance);
        }
    }

    public void moveLeft()
    {
        if (column > 1)
        {
            column--;
            Debug.Log("left");
            startLerp(distance * -1f);
        }
    }

    public void startLerp(float move)
    {
        startPos = rb.transform.position;
        endPos.x = startPos.x + move; // Only update the x-coordinate of endPos
        endPos.y = startPos.y + 0.5f;
        elapsedTime = 0f;
    }

    public void enableSideMovement()
    {
        distance = 1.0f;
    }




}
