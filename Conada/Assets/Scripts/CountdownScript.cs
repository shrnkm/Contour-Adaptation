﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownScript : MonoBehaviour
{
    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;

    private float timer;
    private bool canCount = true;
    private bool doOnce = false;
    private float min;
    private float sec;

    private void Start()
    {
        timer = mainTimer;
    }

    private void Update()
    {
        if (timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            sec = (timer) % 60;
            min = (timer - sec) / 60;
            uiText.text = min.ToString() + ":" + sec.ToString("F");
        }
        
        else if (timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0.00";
            timer = 0.0f;
            Go2Test();
        }
    }

    public void ResetButton()
    {
        timer = mainTimer;
        canCount = true;
        doOnce = false;
    }

    void Go2Test()
    {
        SceneManager.LoadScene("ExpExp");
    }
}
