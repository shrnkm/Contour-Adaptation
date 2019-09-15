using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void ExitNow()
    {
        Application.Quit();
    }

    public void TryAgain()
    {
        SceneManager.LoadScene("FightFlight");
    }
}
