using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart4;
    public GameObject heart5;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playa.health == 4)
        {
            heart1.SetActive(false);
        }
        if (playa.health == 3)
        {
            heart2.SetActive(false);
        }
        if (playa.health == 2)
        {
            heart3.SetActive(false);
        }
        if (playa.health == 1)
        {
            heart4.SetActive(false);
        }
        if (playa.health == 0)
        {
            heart5.SetActive(false);
            playa.health = 5;
            SceneManager.LoadScene("Death");
        }
    }
}
