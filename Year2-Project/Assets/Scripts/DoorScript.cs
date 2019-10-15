using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    Animator Dooranim;

    bool isopen = true;

    // Start is called before the first frame update
    void Start()
    {
        Dooranim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(isopen)
            {
                Dooranim.SetTrigger("CloseDoor");
            }
            else
            {
                Dooranim.SetTrigger("OpenDoor");
            }
            isopen = !isopen;
        }
    }
}
