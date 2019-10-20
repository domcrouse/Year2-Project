using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Health healthScript;
    public Text healthTxt;
    public Slider healthBar;
    public Text scoreNum;
    public Text timeNum;
    static int score;


    // Update is called once per frame
    void Update()
    {
        healthBar.maxValue = healthScript.getMaxHealth();
        healthBar.value = healthScript.getHealth();
        healthTxt.text = "Health:" + healthScript.getHealth();

        timeNum.text = "Time: " + (int)Time.time;
        scoreNum.text = "Score: " + score;
    }

    public static void updateScore(int amount)
    {
        score += amount;
    }
}
