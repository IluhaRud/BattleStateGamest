using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] Transform endOfArea;

    [SerializeField] List<GameObject> areas;

    [SerializeField] GameObject backArea;
    [SerializeField] GameObject forwardArea;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MainCar")
        {
            forwardArea = Instantiate(areas[Random.Range(0, areas.Count)], endOfArea.position, Quaternion.identity);
            forwardArea.gameObject.GetComponent<Trigger>().backArea = gameObject;

            if (backArea != null)
                Destroy(backArea);
        }
    }
}
