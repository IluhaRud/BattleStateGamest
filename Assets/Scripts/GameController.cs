using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] MainCar mainCar;

    public float downPositionX;
    public float upPositionX;
    public float deltaX;
    public float minDeltaX = 100;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            downPositionX = Input.mousePosition.x;
        if (Input.GetMouseButtonUp(0))
        {
            upPositionX = Input.mousePosition.x;
            Swipe();
        }
    }

    public void Swipe()
    {
        deltaX = downPositionX - upPositionX;

        
    }
}
