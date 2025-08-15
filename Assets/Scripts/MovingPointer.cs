using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPointer : MonoBehaviour
{
    Vector3 leftPos;
    Vector3 rightPos;
    bool movingRight = true;
    public float speed = 2;
    bool isMoving = true;

    private void Start()
    {
        leftPos = transform.GetChild(1).position;
        rightPos = transform.GetChild(2).position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isMoving = false;
            print(transform.GetChild(0).GetComponent<PointerDetect>().win);
        }

        if(isMoving == false)
        {
            return;
        }

        if (movingRight)
        {
            transform.GetChild(0).position = Vector3.MoveTowards(transform.GetChild(0).position, rightPos, speed * Time.deltaTime);
            if (Vector3.Distance(transform.GetChild(0).position, rightPos) < 0.05f)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.GetChild(0).position = Vector3.MoveTowards(transform.GetChild(0).position, leftPos, speed * Time.deltaTime);
            if (Vector3.Distance(transform.GetChild(0).position, leftPos) < 0.05f)
            {
                movingRight = true;
            }
        }
    }
}
