﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneScript : MonoBehaviour
{
    public void loadMain()
    {
        SceneManager.LoadScene("Level1");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
