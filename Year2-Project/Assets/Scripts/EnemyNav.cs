using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNav : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent Humanoid;
    public Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").transform;
        Humanoid = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Humanoid.SetDestination (Target.position);

        if(Humanoid.remainingDistance<(Humanoid.stoppingDistance + 0.5f))
        {
            transform.LookAt(Target.transform);
        }
    }
}
