using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class route : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 pointB;
    public float speed;

    IEnumerator Start()
    {
        speed = Random.Range(2.0f,4.0f);
        var pointA = transform.position;
        var pointB = transform.position + Vector3.right * 4;
        while (true)
        {
            yield return StartCoroutine(MoveObject(transform, pointA, pointB, speed));
            yield return StartCoroutine(MoveObject(transform, pointB, pointA, speed));
        }
    }

    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
    {
        var i = 0.0f;
        var rate = 1.0f / time;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
        }
    }
}
