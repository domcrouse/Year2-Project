using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    float nextAttackTrue = -1.0f;
    [SerializeField] float AttackDelay = 1.0f;
    [SerializeField] int damageDealt =5;
    // Start is called before the first frame update

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Time.time >= nextAttackTrue)
        {

            Debug.Log("hit player");

            Health playerHealth = other.GetComponent<Health>();
            playerHealth.Damage(damageDealt);
            nextAttackTrue = Time.time + AttackDelay;

            Debug.Log(playerHealth.getHealth());
        }
    }
}
