using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int health = 5;


    private void OnTriggerEnter(Collider other)
    {
        health -= 1;
    }


    private void Update()
    {
        if (health <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        
    }
}
