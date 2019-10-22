using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    Transform Player;
    Animator Dooranim;

    bool isopen;

    // Start is called before the first frame update
    void Start()
    {
        Dooranim = GetComponent<Animator>();
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Vector3.Distance(transform.position, Player.position)<5)
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
}
