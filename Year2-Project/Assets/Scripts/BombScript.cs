using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    [SerializeField] int doDamage = 0;

    void OnTriggerEnter(Collider collider)
    {
        Health health = collider.GetComponent<Health>();

        if (health != null && collider.tag == "Player")
        {
            health.Damage(doDamage);
            Destroy(gameObject);
        }
    }
}
