﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoTopPage : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("TopPage");
    }
}
