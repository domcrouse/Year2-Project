using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Health healthScript;
    public Text healthTxt;
    public Slider healthBar;


    // Update is called once per frame
    void Update()
    {
        healthBar.maxValue = healthScript.getMaxHealth();
        healthBar.value = healthScript.getHealth();
        healthTxt.text = "Health:" + healthScript.getHealth();
    }
}
