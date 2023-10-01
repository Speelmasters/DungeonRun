using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{

    public Sprite PageImage;
    public List<Sprite> Numbers;
    public int PageNumber;

    public Vector2 startTouchPosition;
    public Vector2 endTouchPosition;

    public PlayerMovement pm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            if(endTouchPosition.x < startTouchPosition.x)
            {
                pm.moveLeft();
            }
            if (endTouchPosition.x > startTouchPosition.x)
            {
                pm.moveRight();
            }
        }
        
    }


   
}
