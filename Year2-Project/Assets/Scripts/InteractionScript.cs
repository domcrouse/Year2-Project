﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Ray mouseRay = GetComponentInChildren<Camera>().ViewportPointToRay(new Vector3(0.5f , 0.5f, 0));
            RaycastHit hitinfo;

            if(Physics.Raycast(mouseRay, out hitinfo))
            {
                DoorOpenScript door = hitinfo.transform.GetComponent<DoorOpenScript>();
                if (door)
                {
                door.isOpen = !door.isOpen;
                }
            }
        }
    }
}
