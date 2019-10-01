using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    Transform PlayerModel;
    CharacterController controller;
    [SerializeField] float MoveSpeed = 3.0f;
    [SerializeField] float gravity = 1.0f;
    float yVelocity = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
        PlayerModel = playerGameObject.transform;
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        if(controller.isGrounded){
            yVelocity-= gravity;
        }
        Vector3 direction = PlayerModel.position - transform.position;
        transform.LookAt(PlayerModel.transform);
        controller.Move (transform.forward * MoveSpeed * Time.deltaTime);
        }
}


