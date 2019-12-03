using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;


public class ExecuteSave : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            SaveGame();
        }

        if(Input.GetKeyDown(KeyCode.L))
        {
            LoadGame();
        }
    }

    private void SaveGame()
    {
        SaveScore save = new SaveScore();

        foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            save.enemyPositions.Add(enemy.transform.position);
        }

        //retrieves the infromation from the player health
        save.playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>().currentHealth;
        //retireves the information from the Players position
        save.playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;

        //writes all of the retrieved information to the text file
        string fileContents = JsonUtility.ToJson(save);
        //saves the retrieved information to the file
        File.WriteAllText(Application.persistentDataPath + "itdoesnthaveone.json", fileContents);
    }

    public void LoadGame()
    {
        //retrieves the save file and loads it
        SaveScore save = JsonUtility.FromJson<SaveScore>(File.ReadAllText(Application.persistentDataPath + "itdoesnthaveone.json"));

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<CharacterController>().enabled = false;
        player.transform.position = save.playerPosition;
        player.GetComponent<CharacterController>().enabled = true;
    }
}
