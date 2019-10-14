using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;

    // Start is called before the first frame update
    void Start()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
    }

    void FixedUpdate()
    {
        Debug.DrawRay(transform.position, (transform.position + (new Vector3 (20 , 0, 0))), Color.red);

        if (Physics.Raycast(transform.position, transform.right, 20))
        {
            Debug.Log("hit");
            Camera1.SetActive(false);
            Camera2.SetActive(true);
        }
        else
        {
            Camera2.SetActive(false);
            Camera1.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
