using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideTap : MonoBehaviour
{
    

    public PlayerMovement pm;
    bool ready = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if(ready)
            {
                if(Input.GetTouch(0).position.x < Screen.width / 2)
                {
                    pm.moveLeft();
                }
                else
                {
                    pm.moveRight();
                }

                ready = false;
            }
        }


        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            ready = true;
        }

    }
}
