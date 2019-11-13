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
    public 
    
    // Update is called once per frame
    void Start()
    {
        GameController Controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

        healthBar = Controller.playerHealth;
        healthTxt = Controller.playerHealthText;
        scoreNum = Controller.Score;
        timeNum = Controller.timeTxt;

        healthBar.maxValue = healthScript.getMaxHealth();
        healthBar.value = healthScript.getHealth();
        healthTxt.text = "Health:" + healthScript.getHealth();

        Debug.Log("From health script " + healthScript.getHealth());

        StartCoroutine("updateUI");
    }
    IEnumerator updateUI()
        {
            healthBar.value = healthScript.getHealth();
            healthTxt.text = "Health: " + healthScript.getHealth();
            timeNum.text = "Time: " + (int)Time.time;
            scoreNum.text = "Score: " + score;

            Debug.Log("From health script " + healthScript.getHealth());

            if (healthScript.isDead)
            {
                GameObject.Find("losePanel").SetActive(true);
                Time.timeScale = 0;
            }

            yield return new WaitForSeconds(0.5f);
            StartCoroutine("updateUI");
        }

    public static void updateScore(int amount)
    {
        score += amount;
    }
}
