using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void ExitNow()
    {
        Application.Quit();
    }

    public void Experiment()
    {
        SceneManager.LoadScene("ContourTest");
    }
}
