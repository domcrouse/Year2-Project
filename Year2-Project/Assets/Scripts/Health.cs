using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int maxHealth = 100;
    int currentHealth = 0;
    public GameObject PlayerModel;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public bool isDead {get{ return currentHealth <= 0;} }

    public int getHealth()
    {
        return currentHealth;
    }

    public int getMaxHealth()
    {
        return maxHealth;
    }

    public void Damage(int damagevalue)
    {
        currentHealth -= damagevalue;

        if(currentHealth < 0)
        {
            Destroy(PlayerModel);
        }
    }
}
