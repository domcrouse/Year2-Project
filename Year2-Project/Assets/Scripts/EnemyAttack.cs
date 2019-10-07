using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    float nextAttackTrue = -1.0f;
    [SerializeField] float AttackDelay = 1.0f;
    [SerializeField] int damaageDealt =5;
    // Start is called before the first frame update

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player"&&Time.time>=nextAttackTrue)
        {
            Health playerHelth = other.GetComponent<Health>();
            playerHelth.Damage(damaageDealt);
            nextAttackTrue = Time.time + AttackDelay;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
