using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    Transform PlayerModel;
    CharacterController controller;
    [SerializeField] float MoveSpeed = 3.0f;
    [SerializeField] float gravity = 1.0f;
    [SerializeField] float rotationSpeed = 5.0f;
    float yVelocity = 0.0f;
    public Transform Enemy;
    public int maxDistance;
    public int minDistance;

    void Awake()
    {
        Enemy = transform;
    }
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
        
        Vector3 direction = PlayerModel.position - transform.position;
        transform.LookAt(PlayerModel.transform);
        controller.Move (transform.forward * MoveSpeed * Time.deltaTime + new Vector3(0, yVelocity, 0));
        
        float Distance = Vector3.Distance(PlayerModel.transform.position, transform.position);

        if (Distance < 1)
        { 
            Vector3 targetDir = PlayerModel.position - Enemy.position;
            targetDir.y = 0;
            Enemy.rotation = Quaternion.Slerp(Enemy.rotation, Quaternion.LookRotation(targetDir), rotationSpeed * Time.deltaTime);
            PlayerModel.position += Enemy.forward * MoveSpeed * Time.deltaTime;
        }

        if(!controller.isGrounded){
            yVelocity-= gravity;

        }
    }
}


