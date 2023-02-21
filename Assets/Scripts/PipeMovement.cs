using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    private float deadZone = -41.5f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}
