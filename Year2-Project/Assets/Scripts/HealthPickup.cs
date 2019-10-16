using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
    {
        [SerializeField] int HealVal = 0;
        
        void OnTriggerEnter(Collider collider)
            {
                //print("pickup")
                Health health = collider.GetComponent<Health>();

                if (health != null && collider.tag == "Player")
                {
                    GetComponent<MeshRenderer>().enabled = false;
                    health.Damage(-HealVal);
                    Destroy(gameObject);
                    Debug.Log("Health");
                }
    }
}