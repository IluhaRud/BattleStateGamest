using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCar : MonoBehaviour
{
    public float speed = 0f;
    public bool isRight;

    public float downPositionX;
    public float upPositionX;
    public float deltaX;


    private void Start()
    {
        if (transform.position.z > 0)
            isRight = true;

        else isRight = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            downPositionX = Input.mousePosition.x;
        if (Input.GetMouseButtonUp(0))
        {
            upPositionX = Input.mousePosition.x;
            Swipe();
        }

            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
    }

    public void Swipe()
    {
        deltaX = downPositionX - upPositionX;

        if (deltaX > 0 && isRight)
        {
            isRight = false;
            transform.position = new Vector3(transform.position.x, transform.position.y, -4); 
        }

        if (deltaX < 0 && !isRight)
        {
            isRight = true;
            transform.position = new Vector3(transform.position.x, transform.position.y, 3);
        }
    }
}
