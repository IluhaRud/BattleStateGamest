using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCars : MonoBehaviour
{
    public int maxCars;
    public int minDistance;

    public Vector2 position;

    int line;

    public List<GameObject> cars;

    private void Start()
    {
        for (int i = 0; i < maxCars; i++)
        {
            line = Random.Range(0, 2);
        }
    }

    void CreateRightCar()
    {

    }

    void CreateLeftCar()
    {

    }
}
