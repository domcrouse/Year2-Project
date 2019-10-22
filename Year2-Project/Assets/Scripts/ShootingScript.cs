using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    [SerializeField] int damageDealt = 20;
    [SerializeField] LayerMask layermask;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        layermask |= Physics.IgnoreRaycastLayer;
        layermask = ~layermask;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        Ray mouseRay = GetComponentInChildren<Camera>().ViewportPointToRay(new Vector3(0.5f ,0.5f, 0));
        RaycastHit hitinfo;
        
        if(Input.GetButtonDown("Fire1")){
            if(Physics.Raycast(mouseRay, out hitinfo, 100, layermask))
            {
                Health enemyHealth = hitinfo.collider.gameObject.GetComponent<Health>();

                if(enemyHealth !=null)
                {
                    enemyHealth.Damage(damageDealt);
                }
            }
        }
    }
}
