using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTwoMove : MonoBehaviour
{
    public Rigidbody2D rb; 

    // Update is called once per frame
    void Update()
    {
        float horizonal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        rb.velocity = new Vector2(horizonal, vertical);

    }
}
