using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenScript : MonoBehaviour
{
    Vector3 startposition;
    public bool isOpen;

    void Start()
    {
        startposition = transform.position;
    }

    void Update()
    {
        if (isOpen)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y + 3 , transform.position.z), Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, startposition, Time.deltaTime);
        }
    }

}
