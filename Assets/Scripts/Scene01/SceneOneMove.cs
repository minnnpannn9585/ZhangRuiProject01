using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneOneMove : MonoBehaviour
{
    public Rigidbody2D rb; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-1f, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(1f,  rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0f, rb.velocity.y);
        }

    }
}
